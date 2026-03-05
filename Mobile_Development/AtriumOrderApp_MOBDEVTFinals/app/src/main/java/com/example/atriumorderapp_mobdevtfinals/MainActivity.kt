package com.example.atriumorderapp_mobdevtfinals

import android.app.Activity
import android.content.Context
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import androidx.activity.result.contract.ActivityResultContracts
import androidx.activity.viewModels
import com.example.atriumorderapp_mobdevtfinals.databinding.ActivityMainBinding
import com.example.atriumorderapp_mobdevtfinals.viewModel.MainViewModel

class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding
    private val viewModel by viewModels<MainViewModel>()
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)
        lifecycle.addObserver(MyObserver())

        val newBalance = intent.getIntExtra("newBalance", 0)
        binding.editTextSetBalance.setText(newBalance.toString())

        binding.btnProceed.setOnClickListener{
            val intent = Intent(this, MealsActivity::class.java)
            val setBalance = binding.editTextSetBalance.text.toString().toIntOrNull() ?: 0
            viewModel.setBalance(setBalance)
            Log.d("MainActivity", "Set balance: $setBalance")
            val sharedPref = getSharedPreferences("balancePref", Context.MODE_PRIVATE)
            val editor = sharedPref.edit()
            editor.putInt("balance", setBalance)
            editor.apply()
            intent.putExtra("balance", setBalance)
            startActivity(intent)
        }

    }

}