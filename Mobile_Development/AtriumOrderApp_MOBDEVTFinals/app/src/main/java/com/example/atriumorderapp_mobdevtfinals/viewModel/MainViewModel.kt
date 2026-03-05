package com.example.atriumorderapp_mobdevtfinals.viewModel

import android.util.Log
import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.SavedStateHandle
import androidx.lifecycle.ViewModel
import com.example.atriumorderapp_mobdevtfinals.R
import com.example.atriumorderapp_mobdevtfinals.dataClass.Drink
import com.example.atriumorderapp_mobdevtfinals.dataClass.Meal
import com.example.atriumorderapp_mobdevtfinals.dataClass.Other

class MainViewModel (private val savedStateHandle: SavedStateHandle):  ViewModel() {

    private val _balance = MutableLiveData<Int>()
    val balance: LiveData<Int> = _balance

    private val _meals = MutableLiveData<List<Meal>>()
    val meals: LiveData<List<Meal>> = _meals

    private val _drinks = MutableLiveData<List<Drink>>()
    val drinks: LiveData<List<Drink>> = _drinks

    private val _others = MutableLiveData<List<Other>>()
    val others: LiveData<List<Other>> = _others


    fun setBalance(Balance: Int) {
        Log.d("MainViewModel", "Balance Set: $Balance")
        _balance.value = Balance
    }

    fun updateMealQuantity(index: Int, quantity: Int) {
        val currentMeals = _meals.value.orEmpty().toMutableList()
        if (index < currentMeals.size) {
            currentMeals[index].quantity = quantity
            currentMeals[index].orderTotal = quantity * currentMeals[index].price
            _meals.value = currentMeals
            Log.d("MainViewModel", "Meal quantity updated: Index $index, New Quantity: $quantity")
        }
    }

    fun updateDrinkQuantity(index: Int, quantity: Int) {
        val currentDrink = _drinks.value.orEmpty().toMutableList()
        if (index < currentDrink.size) {
            currentDrink[index].quantity = quantity
            currentDrink[index].orderTotal = quantity * currentDrink[index].price
            _drinks.value = currentDrink
            Log.d("MainViewModel", "Drink quantity updated: Index $index, New Quantity: $quantity")
        }
    }

    fun updateOtherQuantity(index: Int, quantity: Int) {
        val currentOther = _others.value.orEmpty().toMutableList()
        if (index < currentOther.size) {
            currentOther[index].quantity = quantity
            currentOther[index].orderTotal = quantity * currentOther[index].price
            _others.value = currentOther
            Log.d("MainViewModel", "Other quantity updated: Index $index, New Quantity: $quantity")
        }
    }

    fun updateMealOrderTotal(index: Int, orderTotal: Int) {
        val currentMeals = _meals.value.orEmpty().toMutableList()
        if (index < currentMeals.size) {
            currentMeals[index].orderTotal = orderTotal
            _meals.value = currentMeals
            Log.d("MainViewModel", "Meal order total updated: Index $index, New Order Total: $orderTotal")
        }
    }

    fun updateDrinkOrderTotal(index: Int, orderTotal: Int) {
        val currentDrink = _drinks.value.orEmpty().toMutableList()
        if (index < currentDrink.size) {
            currentDrink[index].orderTotal = orderTotal
            _drinks.value = currentDrink
            Log.d("MainViewModel", "Drink order total updated: Index $index, New Order Total: $orderTotal")
        }
    }

    fun updateOtherOrderTotal(index: Int, orderTotal: Int) {
        val currentOther = _others.value.orEmpty().toMutableList()
        if (index < currentOther.size) {
            currentOther[index].orderTotal = orderTotal
            _others.value = currentOther
            Log.d("MainViewModel", "Other order total updated: Index $index, New Order Total: $orderTotal")
        }
    }

    fun searchMealsByLabel(query: String): List<Meal> {
        val meals = _meals.value.orEmpty()
        if (query.isEmpty()) {
            return meals
        } else {
            return meals.filter { it.meallabel.contains(query, ignoreCase = true) }
        }
    }

    fun searchDrinksByLabel(query: String): List<Drink> {
        val drinks = _drinks.value.orEmpty()
        if (query.isEmpty()) {
            return drinks
        } else {
            return drinks.filter { it.drinklabel.contains(query, ignoreCase = true) }
        }
    }

    fun searchOthersByLabel(query: String): List<Other> {
        val others = _others.value.orEmpty()
        if (query.isEmpty()) {
            return others
        } else {
            return others.filter { it.otherlabel.contains(query, ignoreCase = true) }
        }
    }

    init {
        _balance.value = 0
        initializeMealComponents()
        initializeDrinkComponents()
        initializeOtherComponents()
    }

    private fun initializeOtherComponents() {
        val othersList = listOf(
            Other(R.drawable.sandwich, "Ham Sandwich", 30),
            Other(R.drawable.empanada, "Beef Empanada", 50),
            Other(R.drawable.burger, "Burger", 30),
            Other(R.drawable.cornetto, "Cornetto", 30)

        )
        _others.value = othersList
    }

    private fun initializeDrinkComponents() {
        val drinksList = listOf(
            Drink(R.drawable.aquafina, "Water", 20),
            Drink(R.drawable.c2, "C2", 50),
            Drink(R.drawable.cocacola, "Coke", 50),
            Drink(R.drawable.gatorade, "Gatorade", 50)

        )
        _drinks.value = drinksList
    }

    private fun initializeMealComponents() {
        val mealsList = listOf(
            Meal(R.drawable.kanin, "Rice", 20),
            Meal(R.drawable.chopsuey, "Chopsuey", 90),
            Meal(R.drawable.adobo, "Adobo", 90),
            Meal(R.drawable.porkchop, "Pork Chop", 80)
        )
        _meals.value = mealsList
    }

}









