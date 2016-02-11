//Gualberto Casas - A00942270
//Seung Hoon Lee Kim - A01021720
//Ruben Cuadra

using UnityEngine;
using System;
using System.Collections;

public class Movement_South_Player : MonoBehaviour {
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.A) && transform.position.x>-3.5f) //Si la tecla de la izquierda es apretada, se movera de posicion -.14 hasta un limite de -6.4
			GetComponent<Transform>().Translate ( new Vector2(-0.18f, 0) );
		if (Input.GetKey (KeyCode.D) && transform.position.x<3.2f) //Si la tecla de la izquierda es apretada, se movera de posicion .14 hasta un limite de 6.4
			GetComponent<Transform>().Translate ( new Vector2(0.18f, 0) );
	}
}
