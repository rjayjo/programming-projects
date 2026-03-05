package com.example.atriumorderapp_mobdevtfinals

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.text.TextUtils
import android.view.View
import android.widget.Button
import android.widget.TextView
import android.widget.Toast
import com.example.atriumorderapp_mobdevtfinals.databinding.ActivityRegisterBinding
import com.google.android.material.textfield.TextInputEditText
import com.google.firebase.auth.FirebaseAuth
import com.google.firebase.auth.ktx.auth
import com.google.firebase.ktx.Firebase

class RegisterActivity : AppCompatActivity() {
    private lateinit var auth: FirebaseAuth
    private lateinit var binding: ActivityRegisterBinding

    public override fun onStart() {
        super.onStart()
        val currentUser = auth.currentUser
        if (currentUser != null) {
            val intent = Intent(this@RegisterActivity, MainActivity::class.java)
            startActivity(intent)
        }
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityRegisterBinding.inflate(layoutInflater)
        setContentView(R.layout.activity_register)
        auth = Firebase.auth

        val txtemail: TextInputEditText = findViewById(R.id.txtEmail)
        val txtpassword: TextInputEditText = findViewById(R.id.txtPassword)
        val btnreg: Button = findViewById(R.id.btnRegister)
        val loginred: TextView = findViewById(R.id.tvlogin)

        loginred.setOnClickListener{
            val intent = Intent(this, LoginActivity::class.java)
            startActivity(intent)
        }
        btnreg.setOnClickListener(object : View.OnClickListener {
            override fun onClick(view: View?) {
                val email = txtemail.text.toString()
                val password = txtpassword.text.toString()

                if (TextUtils.isEmpty(email)) {
                    Toast.makeText(
                        this@RegisterActivity, "Please Enter Your Email Address", Toast.LENGTH_SHORT).show()
                    return
                }
                if (TextUtils.isEmpty(password)) {
                    Toast.makeText(
                        this@RegisterActivity, "Please Enter Your Password", Toast.LENGTH_SHORT).show()
                    return
                }

                auth.createUserWithEmailAndPassword(email, password)
                    .addOnCompleteListener() { task ->
                        if (task.isSuccessful) {
                            Toast.makeText(this@RegisterActivity, "Authentication Successful.",
                                Toast.LENGTH_SHORT,).show() } else {
                            Toast.makeText(this@RegisterActivity, "Authentication failed.",
                                Toast.LENGTH_SHORT,).show() }
                    }
            }
        })
    }
}