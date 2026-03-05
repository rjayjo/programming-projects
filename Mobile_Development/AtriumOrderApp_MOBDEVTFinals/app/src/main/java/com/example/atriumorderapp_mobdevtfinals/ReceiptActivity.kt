package com.example.atriumorderapp_mobdevtfinals

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.MenuItem
import android.view.View
import android.widget.TextView
import com.example.atriumorderapp_mobdevtfinals.databinding.ActivityReceiptBinding

class ReceiptActivity : AppCompatActivity() {
    private lateinit var binding: ActivityReceiptBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityReceiptBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val overallTotal = intent.getIntExtra("overallTotal", 0)
        val initialBalance = intent.getIntExtra("initialBalance", 0)
        val remainingBalance = intent.getIntExtra("remainingBalance", 0)

        binding.txtTotalOrder.text = "$overallTotal"
        binding.txtInitialBalance.text = "$initialBalance"
        binding.txtRemainingBalance.text = "$remainingBalance"

        binding.btnBackToMain.setOnClickListener {
            val newBalance = binding.txtRemainingBalance.text.toString().toInt()
            val intent = Intent(this, MainActivity::class.java)
            intent.putExtra("newBalance", newBalance)
            startActivity(intent)
        }

    }

}