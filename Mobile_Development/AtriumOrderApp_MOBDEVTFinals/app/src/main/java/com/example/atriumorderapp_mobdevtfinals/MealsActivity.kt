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
import androidx.activity.viewModels
import com.example.atriumorderapp_mobdevtfinals.databinding.ActivityMealsBinding
import com.example.atriumorderapp_mobdevtfinals.viewModel.MainViewModel
import androidx.appcompat.widget.SearchView
import androidx.appcompat.widget.SearchView.OnQueryTextListener
import com.example.atriumorderapp_mobdevtfinals.dataClass.Meal
import com.google.firebase.auth.FirebaseAuth

class MealsActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMealsBinding
    private val viewModel by viewModels<MainViewModel>()
    private lateinit var sharedPreferences: SharedPreferences
    private lateinit var editor: SharedPreferences.Editor

    private fun openDrinksActivity() {
        val intent = Intent(this, DrinksActivity::class.java)
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
        binding = ActivityMealsBinding.inflate(layoutInflater)
        setContentView(binding.root)
        lifecycle.addObserver(MyObserver())
        getBalance()

        binding.btnCheckout.setOnClickListener {
            val intent = Intent(this, OrdersActivity::class.java)
            startActivity(intent)
        }

        binding.btnSignOut.setOnClickListener{
            FirebaseAuth.getInstance().signOut()
            val intent = Intent(this, LoginActivity::class.java)
            startActivity(intent)
        }
        binding.btnMeals.setOnClickListener { }
        binding.btnDrinks.setOnClickListener { openDrinksActivity() }
        binding.btnOthers.setOnClickListener { openOthersActivity() }
        binding.btnOrders.setOnClickListener { openOrdersActivity() }

        sharedPreferences = getSharedPreferences("mealPrefs", Context.MODE_PRIVATE)
        editor = sharedPreferences.edit()
        searchMealController()
        mealComponentsVMObserver()

        val quantityEditTextList = listOf(
            binding.editTextMeals1Qty,
            binding.editTextMeals2Qty,
            binding.editTextMeals3Qty,
            binding.editTextMeals4Qty
        )

        mealOrderController(quantityEditTextList)
    }

    private fun mealComponentsVMObserver() {
        viewModel.meals.observe(this) { mealsList ->
            for ((index, meal) in mealsList.withIndex()) {
                val imageView = when (index) {
                    0 -> binding.imageViewMeals1
                    1 -> binding.imageViewMeals2
                    2 -> binding.imageViewMeals3
                    3 -> binding.imageViewMeals4
                    else -> null
                }
                imageView?.setImageResource(meal.imageResId)

                val textViewLabel = when (index) {
                    0 -> binding.textViewMealsLabel1
                    1 -> binding.textViewMealsLabel2
                    2 -> binding.textViewMealsLabel3
                    3 -> binding.textViewMealsLabel4
                    else -> null
                }
                textViewLabel?.text = meal.meallabel

                val textViewPrice = when (index) {
                    0 -> binding.textViewMealsPrice1
                    1 -> binding.textViewMealsPrice2
                    2 -> binding.textViewMealsPrice3
                    3 -> binding.textViewMealsPrice4
                    else -> null
                }
                textViewPrice?.text = "PHP ${meal.price}"
            }
        }
    }

    private fun searchMealController() {
        val searchQuery = intent.getStringExtra("searchQuery")
        if (!searchQuery.isNullOrEmpty()) {
            val filteredMeals = viewModel.searchMealsByLabel(searchQuery)
            updateUI(filteredMeals)
        }

        binding.searchViewMeals.setOnQueryTextListener(object : OnQueryTextListener {
            override fun onQueryTextSubmit(query: String?): Boolean {
                if (!query.isNullOrEmpty()) {
                    val filteredMeals = viewModel.searchMealsByLabel(query)
                    updateUI(filteredMeals)
                    hideEditTextComponents()
                } else {
                    updateUI(viewModel.meals.value ?: emptyList())
                    showEditTextComponents()
                }
                return true
            }

            override fun onQueryTextChange(newText: String?): Boolean {
                if (newText.isNullOrEmpty()) {
                    updateUI(viewModel.meals.value ?: emptyList())
                    showEditTextComponents()
                }
                return true
            }
        })
    }

    private fun mealOrderController(quantityEditTextList: List<EditText>) {
        quantityEditTextList.forEachIndexed { index, editText ->
            val savedQuantity = sharedPreferences.getInt("meal_$index", 0)
            editText.setText(savedQuantity.toString())
            editText.addTextChangedListener(object : TextWatcher {
                override fun afterTextChanged(s: Editable?) {
                    var meal = viewModel.meals.value?.get(index)
                    var quantity = s.toString().toIntOrNull() ?: 0
                    if (meal != null) {
                        var orderTotal = quantity * meal.price
                        viewModel.updateMealQuantity(index, quantity)
                        viewModel.updateMealOrderTotal(index, orderTotal)

                        editor.putInt("meal_$index", quantity)
                        editor.apply()
                        Log.d(
                            "MealQuantityTextWatcher",
                            "Meal index: $index, New Quantity: $quantity Price: $orderTotal"
                        )
                    }
                }

                override fun beforeTextChanged(
                    s: CharSequence?, start: Int, count: Int, after: Int) {}
                override fun onTextChanged(s: CharSequence?, start: Int, before: Int, count: Int) {}
            })
        }
    }

    private fun updateUI(meals: List<Meal>) {
        val imageViewList = listOf(
            binding.imageViewMeals1,
            binding.imageViewMeals2,
            binding.imageViewMeals3,
            binding.imageViewMeals4
        )

        val textViewLabelList = listOf(
            binding.textViewMealsLabel1,
            binding.textViewMealsLabel2,
            binding.textViewMealsLabel3,
            binding.textViewMealsLabel4
        )

        val textViewPriceList = listOf(
            binding.textViewMealsPrice1,
            binding.textViewMealsPrice2,
            binding.textViewMealsPrice3,
            binding.textViewMealsPrice4
        )

        imageViewList.forEach { it.setImageResource(0) }
        textViewLabelList.forEach { it.text = "" }
        textViewPriceList.forEach { it.text = "" }

        for ((index, meal) in meals.withIndex()) {
            if (index < imageViewList.size) {
                imageViewList[index].setImageResource(meal.imageResId)
                textViewLabelList[index].text = meal.meallabel
                textViewPriceList[index].text = "PHP ${meal.price}"
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
            binding.editTextMeals1Qty,
            binding.editTextMeals2Qty,
            binding.editTextMeals3Qty,
            binding.editTextMeals4Qty
        )

        quantityEditTextList.forEach { it.visibility = View.GONE }
    }

    private fun showEditTextComponents() {
        val quantityEditTextList = listOf(
            binding.editTextMeals1Qty,
            binding.editTextMeals2Qty,
            binding.editTextMeals3Qty,
            binding.editTextMeals4Qty
        )

        quantityEditTextList.forEach { it.visibility = View.VISIBLE }
    }
}