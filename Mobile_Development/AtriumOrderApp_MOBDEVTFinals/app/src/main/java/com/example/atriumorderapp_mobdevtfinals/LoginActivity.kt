package com.example.atriumorderapp_mobdevtfinals

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.text.TextUtils
import android.view.View
import android.widget.Toast
import com.example.atriumorderapp_mobdevtfinals.databinding.ActivityLoginBinding
import com.google.firebase.auth.FirebaseAuth

class LoginActivity : AppCompatActivity() {
    private lateinit var auth: FirebaseAuth
    private lateinit var binding: ActivityLoginBinding

    public override fun onStart() {
        super.onStart()
        val currentUser = auth.currentUser
        if (currentUser != null) {
            val intent = Intent(this@LoginActivity, MainActivity::class.java)
            startActivity(intent)
        }
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityLoginBinding.inflate(layoutInflater)
        setContentView(binding.root)
//        auth = Firebase.auth
        auth = FirebaseAuth.getInstance()
        val txtemail = binding.txtEmail
        val txtpassword = binding.txtPassword
        val btnlogin = binding.btnLogin
        val regred = binding.tvsignup
        regred.setOnClickListener{
            val intent = Intent(this, RegisterActivity::class.java)
            startActivity(intent)
        }

        btnlogin.setOnClickListener(object : View.OnClickListener {
            override fun onClick(view: View?) {
                val email = txtemail.text.toString()
                val password = txtpassword.text.toString()

                if (TextUtils.isEmpty(email)) {
                    Toast.makeText(
                        this@LoginActivity, "Please Enter Your Email Address", Toast.LENGTH_SHORT).show()
                    return
                }
                if (TextUtils.isEmpty(password)) {
                    Toast.makeText(
                        this@LoginActivity, "Please Enter Your Password", Toast.LENGTH_SHORT).show()
                    return
                }

                auth.signInWithEmailAndPassword(email, password)
                    .addOnCompleteListener() { task ->
                        if (task.isSuccessful) {
                            Toast.makeText(this@LoginActivity,"Welcome to the Canteen App",
                                Toast.LENGTH_SHORT,).show()
                            val intent = Intent(this@LoginActivity, MainActivity::class.java)
                            startActivity(intent)
                        } else {
                            Toast.makeText(this@LoginActivity,"Log In failed.",
                                Toast.LENGTH_SHORT,).show()
                        }
                    }


            }
        })

    }
}