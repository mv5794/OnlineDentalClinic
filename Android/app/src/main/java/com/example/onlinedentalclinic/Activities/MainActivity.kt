package com.example.onlinedentalclinic.Activities

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.example.onlinedentalclinic.R
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        buttonLoginPaciente.setOnClickListener(){
            val myIntent = Intent(this, ListaCitasPacienteActivity::class.java)
            startActivity(myIntent)
        }
        buttonRegistrarUsuario.setOnClickListener(){
            val myIntent = Intent(this, RegistrarUsuarioActivity::class.java)
            startActivity(myIntent)
        }
    }
}
