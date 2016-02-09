﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MovimientoPelota : MonoBehaviour {
	// Variables globales para las fuerzas aplicadas a la pelota
	private Vector2 _fuerza, _fuerza1, _fuerza2, _fuerza3, _fuerza4;
	private int _puntosIzq = 0, _puntosDer = 0;
	private bool _der, _izq, _aba, _arr;
	public Text _puntos;

	// Use this for initialization
	void Start () {
		_fuerza = new Vector2 ( 200, -50 );
		_fuerza1 = new Vector2 ( -250, -150 ); // Hacia izq y abajo
		_fuerza2 = new Vector2 ( 250, -150 ); // Hacia der y abajo
		_fuerza3 = new Vector2 ( 250, 150 ); // Hacia der y arriba
		_fuerza4 = new Vector2 ( -250, 150 ); // Hacia izq y arriba
		GetComponent<Rigidbody2D> ().AddForce ( _fuerza );
		_der = true;
		_izq = _aba = _arr = false;
		_puntos.text = "Marcador: "+_puntosIzq+"-"+_puntosDer+" ";
	}

	/*
	 * Funcion que detecta colisiones.
	 **/
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "BarraDer") {
			if (_aba)
				GetComponent<Rigidbody2D> ().AddForce (_fuerza4);
			else if (_arr)
				GetComponent<Rigidbody2D> ().AddForce (_fuerza1);
			else if (_der)
				GetComponent<Rigidbody2D> ().AddForce (_fuerza1);
			_der = true;
			_izq = _aba = _arr = false;
		} else if (col.gameObject.name == "LimiteAbajo") {
			if (_izq)
				GetComponent<Rigidbody2D> ().AddForce (_fuerza3);
			else if (_der)
				GetComponent<Rigidbody2D> ().AddForce (_fuerza4);
			_aba = true;
			_izq = _der = _arr = false;
		} else if (col.gameObject.name == "BarraIzq") {
			if (_aba)
				GetComponent<Rigidbody2D> ().AddForce (_fuerza3);
			else if (_arr)
				GetComponent<Rigidbody2D> ().AddForce (_fuerza2);
			_izq = true;
			_der = _aba = _arr = false;
		} else if (col.gameObject.name == "LimiteArriba") {
			if (_izq)
				GetComponent<Rigidbody2D> ().AddForce (_fuerza2);
			else if (_der)
				GetComponent<Rigidbody2D> ().AddForce (_fuerza1);
			_arr = true;
			_izq = _der = _aba = false;
		} else if (col.gameObject.name == "MetaIzq"){
			_puntosDer++;
			_puntos.text = "Marcador: "+_puntosIzq+"-"+_puntosDer;
		} else if (col.gameObject.name == "MetaDer"){
			_puntosIzq++;
			_puntos.text = "Marcador: "+_puntosIzq+"-"+_puntosDer;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}