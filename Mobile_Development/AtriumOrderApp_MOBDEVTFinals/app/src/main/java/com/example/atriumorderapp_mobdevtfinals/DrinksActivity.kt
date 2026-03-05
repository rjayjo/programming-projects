package com.example.atriumorderapp_mobdevtfinals

import android.content.Context
import android.content.Intent
import android.content.SharedPreferences
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.text.Editable
import android.text.TextWatcher
import android.util.Log
import android.view.View
import android.widget.EditText
import android.widget.ImageView
import android.widget.TextView
import androidx.activity.viewModels
import androidx.appcompat.widget.SearchView
import androidx.lifecycle.Observer
import androidx.lifecycle.ViewModelProvider
import com.example.atriumorderapp_mobdevtfinals.dataClass.Drink
import com.example.atriumorderapp_mobdevtfinals.dataClass.Meal
import com.example.atriumorderapp_mobdevtfinals.databinding.ActivityDrinksBinding
import com.example.atriumorderapp_mobdevtfinals.viewModel.MainViewModel
import com.google.firebase.auth.FirebaseAuth
import com.google.gson.Gson

class DrinksActivity : AppCompatActivity() {
    private lateinit var binding: ActivityDrinksBinding
    private val viewModel by viewModels<MainViewModel>()
    private lateinit var sharedPreferences: SharedPreferences
    private lateinit var editor: SharedPreferences.Editor

    private fun openMealsActivity() {
        val intent = Intent(this, MealsActivity::class.java)
        startActivity(intent)
    }

    private fun openOthersActivity() {
        val intent = Intent(this, OthersActivity::class.java)
        startActivity(intent)
    }

    private fun openOrdersActivity() {
        val intent = Intent(this, OrdersActivity::class.java)
        startActivity(intent)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityDrinksBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.btnSignOut.setOnClickListener{
            FirebaseAuth.getInstance().signOut()
            val intent = Intent(this, LoginActivity::class.java)
            startActivity(intent)
        }
        binding.btnMeals.setOnClickListener { openMealsActivity() }
        binding.btnDrinks.setOnClickListener { }
        binding.btnOthers.setOnClickListener { openOthersActivity() }
        binding.btnOrders.setOnClickListener { openOrdersActivity() }
        getBalance()
        binding.btnCheckout.setOnClickListener {
            val intent = Intent(this, OrdersActivity::class.java)
            startActivity(intent)
        }
        sharedPreferences = getSharedPreferences("drinkPrefs", Context.MODE_PRIVATE)
        editor = sharedPreferences.edit()

        searchDrinkController()
        drinkComponentsVMObserver()
        val quantityEditTextList = listOf(
            binding.editTextDrinks1Qty,
            binding.editTextDrinks2Qty,
            binding.editTextDrinks3Qty,
            binding.editTextDrinks4Qty
        )
        drinksOrderController(quantityEditTextList)

    }

    private fun drinkComponentsVMObserver() {
        viewModel.drinks.observe(this) { drinksList ->
            for ((index, drinks) in drinksList.withIndex()) {
                val imageView = when (index) {
                    0 -> binding.imageViewDrinks1
                    1 -> binding.imageViewDrinks2
                    2 -> binding.imageViewDrinks3
                    3 -> binding.imageViewDrinks4
                    else -> null
                }
                imageView?.setImageResource(drinks.imageResId)

                val textViewLabel = when (index) {
                    0 -> binding.textViewDrinksLabel1
                    1 -> binding.textViewDrinksLabel2
                    2 -> binding.textViewDrinksLabel3
                    3 -> binding.textViewDrinksLabel4
                    else -> null
                }
                textViewLabel?.text = drinks.drinklabel

                val textViewPrice = when (index) {
                    0 -> binding.textViewDrinksPrice1
                    1 -> binding.textViewDrinksPrice2
                    2 -> binding.textViewDrinksPrice3
                    3 -> binding.textViewDrinksPrice4
                    else -> null
                }
                textViewPrice?.text = "PHP ${drinks.price}"

            }
        }
    }

    private fun searchDrinkController() {
        val searchQuery = intent.getStringExtra("searchQuery")
        if (!searchQuery.isNullOrEmpty()) {
            val filteredDrinks = viewModel.searchDrinksByLabel(searchQuery)
            updateUI(filteredDrinks)
        }

        binding.searchViewDrinks.setOnQueryTextListener(object : SearchView.OnQueryTextListener {
            override fun onQueryTextSubmit(query: String?): Boolean {
                if (!query.isNullOrEmpty()) {
                    val filteredDrinks = viewModel.searchDrinksByLabel(query)
                    updateUI(filteredDrinks)
                    hideEditTextComponents()
                } else {
                    updateUI(viewModel.drinks.value ?: emptyList())
                    showEditTextComponents()
                }
                return true
            }

            override fun onQueryTextChange(newText: String?): Boolean {
                if (newText.isNullOrEmpty()) {
                    updateUI(viewModel.drinks.value ?: emptyList())
                    showEditTextComponents()
                }
                return true
            }
        })
    }

    private fun drinksOrderController(quantityEditTextList: List<EditText>) {
        quantityEditTextList.forEachIndexed { index, editText ->
            val savedQuantity = sharedPreferences.getInt("drink_$index", 0)
            editText.setText(savedQuantity.toString())
            editText.addTextChangedListener(object : TextWatcher {
                override fun afterTextChanged(s: Editable?) {
                    var drink = viewModel.drinks.value?.get(index)
                    var quantity = s.toString().toIntOrNull() ?: 0
                    if (drink != null) {
                        var orderTotal = quantity * drink.price
                        viewModel.updateDrinkQuantity(index, quantity)
                        viewModel.updateDrinkOrderTotal(index, orderTotal)

                        editor.putInt("drink_$index", quantity)
                        editor.apply()
                        Log.d(
                            "DrinkQuantityTextWatcher",
                            "Drink index: $index, New Quantity: $quantity Price: $orderTotal"
                        )
                    }
                }

                override fun beforeTextChanged(s: CharSequence?, start: Int, count: Int, after: Int) {}
                override fun onTextChanged(s: CharSequence?, start: Int, before: Int, count: Int) {}
            })
        }
    }

    private fun updateUI(drinks: List<Drink>) {
        val imageViewList = listOf(
            binding.imageViewDrinks1,
            binding.imageViewDrinks2,
            binding.imageViewDrinks3,
            binding.imageViewDrinks4
        )

        val textViewLabelList = listOf(
            binding.textViewDrinksLabel1,
            binding.textViewDrinksLabel2,
            binding.textViewDrinksLabel3,
            binding.textViewDrinksLabel4
        )

        val textViewPriceList = listOf(
            binding.textViewDrinksPrice1,
            binding.textViewDrinksPrice2,
            binding.textViewDrinksPrice3,
            binding.textViewDrinksPrice4
        )

        imageViewList.forEach { it.setImageResource(0) }
        textViewLabelList.forEach { it.text = "" }
        textViewPriceList.forEach { it.text = "" }

        for ((index, drink) in drinks.withIndex()) {
            if (index < imageViewList.size) {
                imageViewList[index].setImageResource(drink.imageResId)
                textViewLabelList[index].text = drink.drinklabel
                textViewPriceList[index].text = "PHP ${drink.price}"
            }
        }
    }

    private fun getBalance() {
        val sharedPref = getSharedPreferences("balancePref", MODE_PRIVATE)
        val balanceFromPrefs = sharedPref.getInt("balance", 0)
        viewModel.setBalance(balanceFromPrefs)
        viewModel.balance.observe(this) { balance ->
            binding.txtBalance.text = "Available Balance: PHP $balance"
        }
    }

    private fun hideEditTextComponents() {
        val quantityEditTextList = listOf(
            binding.editTextDrinks1Qty,
            binding.editTextDrinks2Qty,
            binding.editTextDrinks3Qty,
            binding.editTextDrinks4Qty
        )

        quantityEditTextList.forEach { it.visibility = View.GONE }
    }

    private fun showEditTextComponents() {
        val quantityEditTextList = listOf(
            binding.editTextDrinks1Qty,
            binding.editTextDrinks2Qty,
            binding.editTextDrinks3Qty,
            binding.editTextDrinks4Qty
        )

        quantityEditTextList.forEach { it.visibility = View.VISIBLE }
    }

}

