package com.example.onlinedentalclinic.Activities

import android.content.Intent
import android.os.Bundle
import com.google.android.material.snackbar.Snackbar
import androidx.appcompat.app.AppCompatActivity
import com.example.onlinedentalclinic.R

import kotlinx.android.synthetic.main.activity_lista_citas_paciente.*

class ListaCitasPacienteActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_lista_citas_paciente)
        setSupportActionBar(toolbar)

        fab.setOnClickListener { view ->
            val myIntent = Intent(this, AgregarCitaActivity::class.java)
            startActivity(myIntent)
        }
    }

}
