package com.example.atriumorderapp_mobdevtfinals

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.TextView
import android.widget.Toast
import androidx.activity.viewModels
import androidx.core.content.ContextCompat
import com.example.atriumorderapp_mobdevtfinals.databinding.ActivityOrdersBinding
import com.example.atriumorderapp_mobdevtfinals.viewModel.MainViewModel
import com.google.android.material.snackbar.Snackbar
import com.google.firebase.auth.FirebaseAuth


class OrdersActivity : AppCompatActivity() {
    private val viewModel by viewModels<MainViewModel>()
    private lateinit var binding: ActivityOrdersBinding
    private var overallTotalSum: Int = 0
    private val mealOrderTotals = mutableListOf<Int>()
    private val drinkOrderTotals = mutableListOf<Int>()
    private val otherOrderTotals = mutableListOf<Int>()


    private fun openMealsActivity() {
        val intent = Intent(this, MealsActivity::class.java)
        startActivity(intent)
    }



    private fun openDrinksActivity() {
        val intent = Intent(this, DrinksActivity::class.java)
        startActivity(intent)
    }

    private fun openOthersActivity() {
        val intent = Intent(this, OthersActivity::class.java)
        startActivity(intent)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityOrdersBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.btnSignOut.setOnClickListener{
            FirebaseAuth.getInstance().signOut()
            val intent = Intent(this, LoginActivity::class.java)
            startActivity(intent)
        }
        binding.btnMeals.setOnClickListener { openMealsActivity() }
        binding.btnDrinks.setOnClickListener { openDrinksActivity() }
        binding.btnOthers.setOnClickListener { openOthersActivity() }
        binding.btnOrders.setOnClickListener { }
        getBalance()
        orderMealController(mealOrderTotals)
        orderDrinkController(drinkOrderTotals)
        orderOtherController(otherOrderTotals)
        overallPriceOrderHandler()

    }

    private fun overallPriceOrderHandler() {
        binding.textViewOverallTotal.text = "Total Order Price: $overallTotalSum"
        binding.btnFinalizeOrder.setOnClickListener {
            val initialBalance = viewModel.balance.value ?: 0
            val remainingBalance = initialBalance - overallTotalSum
            if (remainingBalance >= 0) {
                val confirmationSnackbar = Snackbar.make(
                    binding.root, "Are you sure you want to proceed with your orders? " +
                            "You cannot refund once you commit.",
                    Snackbar.LENGTH_LONG
                )
                confirmationSnackbar.setAction("Yes") {
                    val intent = Intent(this, ReceiptActivity::class.java)
                    intent.putExtra("overallTotal", overallTotalSum)
                    intent.putExtra("initialBalance", initialBalance)
                    intent.putExtra("remainingBalance", remainingBalance)
                    startActivity(intent)
                }
                confirmationSnackbar.show()
            } else {
                Toast.makeText(this, "Sorry, you have insufficient balance.", Toast.LENGTH_SHORT)
                    .show()
            }
        }
    }

    private fun orderOtherController(otherOrderTotals: MutableList<Int>) {
        val sharedOtherPreferences = getSharedPreferences("otherPrefs", MODE_PRIVATE)
        val otherPrices = viewModel.others.value?.map { it.price } ?: listOf()

        val quantityList = mutableListOf<Int>()
        for (index in 0 until 4) {
            val savedQuantity = sharedOtherPreferences.getInt("other_$index", 0)
            quantityList.add(savedQuantity)
        }

        val orderTotals = mutableListOf<Int>()
        for (i in quantityList.indices) {
            val orderTotal = quantityList[i] * otherPrices.getOrElse(i) { 0 }
            orderTotals.add(orderTotal)
            overallTotalSum += orderTotal
        }

        val selectedOther = viewModel.others.value ?: emptyList()
        for ((i, other) in selectedOther.withIndex()) {
            val orderQuantity = quantityList[i]
            val orderTotal = orderTotals[i]
            if (orderQuantity != 0) {
                val otherInfoTextView = TextView(this)
                otherInfoTextView.text =
                    "Other: ${other.otherlabel}, Quantity: $orderQuantity, Total: PHP $orderTotal"
                binding.othersContainer.addView(otherInfoTextView)
            }
        }
    }

    private fun orderDrinkController(drinkOrderTotals: MutableList<Int>) {
        val sharedDrinkPreferences = getSharedPreferences("drinkPrefs", MODE_PRIVATE)
        val drinkPrices = viewModel.drinks.value?.map { it.price } ?: listOf()

        val quantityList = mutableListOf<Int>()
        for (index in 0 until 4) {
            val savedQuantity = sharedDrinkPreferences.getInt("drink_$index", 0)
            quantityList.add(savedQuantity)
        }

        val orderTotals = mutableListOf<Int>()
        for (i in quantityList.indices) {
            val orderTotal = quantityList[i] * drinkPrices.getOrElse(i) { 0 }
            orderTotals.add(orderTotal)
            overallTotalSum += orderTotal
        }

        val selectedDrinks = viewModel.drinks.value ?: emptyList()
        for ((i, meal) in selectedDrinks.withIndex()) {
            val orderQuantity = quantityList[i]
            val orderTotal = orderTotals[i]
            if (orderQuantity != 0) {
                val drinkInfoTextView = TextView(this)
                drinkInfoTextView.text =
                    "Drink: ${meal.drinklabel}, Quantity: $orderQuantity, Total: PHP $orderTotal"
                binding.drinkContainer.addView(drinkInfoTextView)
            }
        }
    }

    private fun orderMealController(mealOrderTotals: MutableList<Int>) {
        val sharedMealPreferences = getSharedPreferences("mealPrefs", MODE_PRIVATE)
        val mealPrices = viewModel.meals.value?.map { it.price } ?: listOf()

        val quantityList = mutableListOf<Int>()
        for (index in 0 until 4) {
            val savedQuantity = sharedMealPreferences.getInt("meal_$index", 0)
            quantityList.add(savedQuantity)
        }

        val orderTotals = mutableListOf<Int>()
        for (i in quantityList.indices) {
            val orderTotal = quantityList[i] * mealPrices.getOrElse(i) { 0 }
            orderTotals.add(orderTotal)
            overallTotalSum += orderTotal
        }

        val selectedMeals = viewModel.meals.value ?: emptyList()
        for ((i, meal) in selectedMeals.withIndex()) {
            val orderQuantity = quantityList[i]
            val orderTotal = orderTotals[i]
            if (orderQuantity != 0) {
                val mealInfoTextView = TextView(this)
                mealInfoTextView.text =
                    "Meal: ${meal.meallabel}, Quantity: $orderQuantity, Total: PHP $orderTotal"
                binding.mealContainer.addView(mealInfoTextView)
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

}











