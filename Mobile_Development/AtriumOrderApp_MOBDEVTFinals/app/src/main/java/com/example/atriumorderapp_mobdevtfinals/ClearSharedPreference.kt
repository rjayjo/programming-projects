package com.example.atriumorderapp_mobdevtfinals

import android.app.Application
import android.content.Context
import android.content.SharedPreferences
import android.util.Log

class ClearSharedPreference: Application() {
private lateinit var sharedPreferences:SharedPreferences
private lateinit var editor: SharedPreferences.Editor
    override fun onTerminate() {
        super.onTerminate()
        Log.d("ClearSharedPreference", "onTerminate called")
        sharedPreferences = getSharedPreferences("mealPrefs", Context.MODE_PRIVATE)
        sharedPreferences = getSharedPreferences("drinkPrefs", Context.MODE_PRIVATE)
        sharedPreferences = getSharedPreferences("otherPrefs", Context.MODE_PRIVATE)
        editor = sharedPreferences.edit()
        editor.clear()
        editor.apply()
    }
}
