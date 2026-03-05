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
import androidx.appcompat.widget.SearchView
import com.example.atriumorderapp_mobdevtfinals.dataClass.Other
import com.example.atriumorderapp_mobdevtfinals.databinding.ActivityOthersBinding
import com.example.atriumorderapp_mobdevtfinals.viewModel.MainViewModel
import com.google.firebase.auth.FirebaseAuth

class OthersActivity : AppCompatActivity() {
    private lateinit var binding: ActivityOthersBinding
    private val viewModel by viewModels<MainViewModel>()
    private lateinit var sharedPreferences: SharedPreferences
    private lateinit var editor: SharedPreferences.Editor
    private fun openMealsActivity() {
        val intent = Intent(this, MealsActivity::class.java)
        startActivity(intent)
    }
    private fun openDrinksActivity() {
        val intent = Intent(this, DrinksActivity::class.java)
        startActivity(intent)
    }
    private fun openOrdersActivity() {
        val intent = Intent(this, OrdersActivity::class.java)
        startActivity(intent)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityOthersBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.btnSignOut.setOnClickListener{
            FirebaseAuth.getInstance().signOut()
            val intent = Intent(this, LoginActivity::class.java)
            startActivity(intent)
        }
        binding.btnMeals.setOnClickListener  { openMealsActivity() }
        binding.btnDrinks.setOnClickListener { openDrinksActivity() }
        binding.btnOthers.setOnClickListener { }
        binding.btnOrders.setOnClickListener { openOrdersActivity() }
        binding.btnCheckout.setOnClickListener {
            val intent = Intent(this, OrdersActivity::class.java)
            startActivity(intent)
        }
        sharedPreferences = getSharedPreferences("otherPrefs", Context.MODE_PRIVATE)
        editor = sharedPreferences.edit()

        searchOtherController()
        getBalance()
        otherComponentsVMObserver()

        val quantityEditTextList = listOf(
            binding.editTextOthers1Qty,
            binding.editTextOthers2Qty,
            binding.editTextOthers3Qty,
            binding.editTextOthers4Qty
        )
        otherOrderController(quantityEditTextList)
    }

    private fun otherOrderController(quantityEditTextList: List<EditText>) {
        quantityEditTextList.forEachIndexed { index, editText ->
            val savedQuantity = sharedPreferences.getInt("other_$index", 0)
            editText.setText(savedQuantity.toString())
            editText.addTextChangedListener(object : TextWatcher {
                override fun afterTextChanged(s: Editable?) {
                    var other = viewModel.others.value?.get(index)
                    var quantity = s.toString().toIntOrNull() ?: 0
                    if (other != null) {
                        var orderTotal = quantity * other.price
                        viewModel.updateOtherQuantity(index, quantity)
                        viewModel.updateOtherOrderTotal(index, orderTotal)

                        editor.putInt("other_$index", quantity)
                        editor.apply()
                        Log.d(
                            "OtherQuantityTextWatcher",
                            "Other index: $index, New Quantity: $quantity Price: $orderTotal"
                        )
                    }
                }

                override fun beforeTextChanged(s: CharSequence?, start: Int, count: Int, after: Int) {}
                override fun onTextChanged(s: CharSequence?, start: Int, before: Int, count: Int) {}
            })
        }
    }

    private fun otherComponentsVMObserver() {
        viewModel.others.observe(this) { othersList ->
            for ((index, others) in othersList.withIndex()) {
                val imageView = when (index) {
                    0 -> binding.imageViewOthers1
                    1 -> binding.imageViewOthers2
                    2 -> binding.imageViewOthers3
                    3 -> binding.imageViewOthers4
                    else -> null
                }
                imageView?.setImageResource(others.imageResId)

                val textViewLabel = when (index) {
                    0 -> binding.textViewOthersLabel1
                    1 -> binding.textViewOthersLabel2
                    2 -> binding.textViewOthersLabel3
                    3 -> binding.textViewOthersLabel4
                    else -> null
                }
                textViewLabel?.text = others.otherlabel

                val textViewPrice = when (index) {
                    0 -> binding.textViewOthersPrice1
                    1 -> binding.textViewOthersPrice2
                    2 -> binding.textViewOthersPrice3
                    3 -> binding.textViewOthersPrice4
                    else -> null
                }
                textViewPrice?.text = "PHP ${others.price}"

            }
        }
    }

    private fun searchOtherController() {
        val searchQuery = intent.getStringExtra("searchQuery")
        if (!searchQuery.isNullOrEmpty()) {
            val filteredOthers = viewModel.searchOthersByLabel(searchQuery)
            updateUI(filteredOthers)
        }

        binding.searchViewOthers.setOnQueryTextListener(object : SearchView.OnQueryTextListener {
            override fun onQueryTextSubmit(query: String?): Boolean {
                if (!query.isNullOrEmpty()) {
                    val filteredOthers = viewModel.searchOthersByLabel(query)
                    updateUI(filteredOthers)
                    hideEditTextComponents()
                } else {
                    updateUI(viewModel.others.value ?: emptyList())
                    showEditTextComponents()
                }
                return true
            }

            override fun onQueryTextChange(newText: String?): Boolean {
                if (newText.isNullOrEmpty()) {
                    updateUI(viewModel.others.value ?: emptyList())
                    showEditTextComponents()
                }
                return true
            }
        })
    }

    private fun updateUI(others: List<Other>) {
        val imageViewList = listOf(
            binding.imageViewOthers1,
            binding.imageViewOthers2,
            binding.imageViewOthers3,
            binding.imageViewOthers4
        )

        val textViewLabelList = listOf(
            binding.textViewOthersLabel1,
            binding.textViewOthersLabel2,
            binding.textViewOthersLabel3,
            binding.textViewOthersLabel4
        )

        val textViewPriceList = listOf(
            binding.textViewOthersPrice1,
            binding.textViewOthersPrice2,
            binding.textViewOthersPrice3,
            binding.textViewOthersPrice4
        )

        imageViewList.forEach { it.setImageResource(0) }
        textViewLabelList.forEach { it.text = "" }
        textViewPriceList.forEach { it.text = "" }

        for ((index, other) in others.withIndex()) {
            if (index < imageViewList.size) {
                imageViewList[index].setImageResource(other.imageResId)
                textViewLabelList[index].text = other.otherlabel
                textViewPriceList[index].text = "PHP ${other.price}"
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
            binding.editTextOthers1Qty,
            binding.editTextOthers2Qty,
            binding.editTextOthers3Qty,
            binding.editTextOthers4Qty
        )

        quantityEditTextList.forEach { it.visibility = View.GONE }
    }

    private fun showEditTextComponents() {
        val quantityEditTextList = listOf(
            binding.editTextOthers1Qty,
            binding.editTextOthers2Qty,
            binding.editTextOthers3Qty,
            binding.editTextOthers4Qty
        )

        quantityEditTextList.forEach { it.visibility = View.VISIBLE }
    }
}