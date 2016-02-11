//Gualberto Casas- A00942270
//Seung Hoon Lee Kim - A01021720
//Ruben Cuadra

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MovimientoPelota : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	// Variables globales para las fuerzas aplicadas a la pelota
	public static float speed = 5; //Esta es la velocidad a la que la pelota siempre se va a ir moviendo.

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (InitiateBall ());
	}

	IEnumerator InitiateBall()
	{
		yield return new WaitForSeconds (3.0f);
		speed = 5;
		float random = Random.value; //Se crea un numero random float entre el 0 y el 1. Esto es para decidir hacia que lado se ira la pelota cuaundo empeize el juego

		if (random <= 0.25) //Si esta entre 0 y 0.25, se ira hacia arriba a la derecha
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed/2, speed);
		else if (random > 0.25 && random <= 0.50) //Si esta entre .25 y 0.5, se ira hacia abajo a la derecha
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed/2, -speed);
		else if (random > 0.50 && random <= 0.75) //Si esta entre 0.5 y 0.75, se ira la izquierda arriba
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed/2, speed);
		else if (random > 0.75 && random <= 1.00) //Si esta entre 0.75 y 1, se ira a la izquierda abajo
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed/2, -speed);

		GameScore.resetScore ();
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.R)) { //Si la tecla R se llega a apretar
			GameScore.resetScore (); //Mandamos a llamar la funcion de resetscore in gamescore
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0); //Se regresa la velocidad a 0,0
			GetComponent<Rigidbody2D> ().transform.position = new Vector2 (0, 0); //Se regresa la bola a la posicion 0,0
			player1.transform.position = new Vector2 (-0.05f, -2.78f); //Regresamos la posicion de ambos jugadores
			player2.transform.position = new Vector2 (-0.05f, 2.82f); //Regresamos la posicion de ambos jugadores.
			StartCoroutine (InitiateBall()); //Volvemos a llamar la funcion de initiateball
		}
	}
}