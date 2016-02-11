//Gualberto Casas - A00942270
//Seung Hoon Lee Kim - A01021720
//Ruben Cuadra

using UnityEngine;
using UnityEngine;
using System.Collections;

public class Player2Score : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;

	void OnCollisionEnter2D(Collision2D ball)  //El momento en que se colisiona con la pared del sur, se manda a llamar esta funcion (Se adjunta este script a la pared del sur)
	{
		GameScore.player2Score += 10; //Se le agrega 10 puntos al jugador #2, mandando a llamar la variable player2Score en GameScore.cs
		ball.transform.position = new Vector2 (0, 0); //Se reinicia la pelota en el lugar inicial
		player1.transform.position = new Vector2 (-0.05f, 2.82f); //Se reinicia la posicion de este jugador
		player2.transform.position = new Vector2 (-0.05f, -2.78f); //Se reinicia la posicion de este jugador
		ball.rigidbody.velocity = new Vector2 (0, 0); //El movimiento se reinicia al movimiento inicial qeu fue 5
		StartCoroutine (InitiateBall (ball)); //Se manda a llamar la funcion para que se espere 2 segundos
	}

	IEnumerator InitiateBall(Collision2D ball) //Esta funcion se manda a llamar al mismo tiempo y es para que se espere 2 segundos
	{
		MovimientoPelota.speed = 5; //El movimiento se reinicia al movimiento inicial qeu fue 5
		yield return new WaitForSeconds(2.0f); 
		//El siguiente codigo fue copiado de movimiento pelota para que se vuelva a llamar la posicion y la velocidad de la pelota.
		float random = Random.value; //Se crea un numero random float entre el 0 y el 1. Esto es para decidir hacia que lado se ira la pelota cuaundo empeize el juego 
		if (random <= 0.25) ball.rigidbody.velocity = new Vector2 (MovimientoPelota.speed/2, MovimientoPelota.speed); //Si esta entre 0 y 0.25, se ira hacia arriba a la derecha
		else if (random > 0.25 && random <= 0.50) ball.rigidbody.velocity = new Vector2 (MovimientoPelota.speed/2, -MovimientoPelota.speed); //Si esta entre .25 y 0.5, se ira hacia abajo a la derecha
		else if (random > 0.50 && random <= 0.75) ball.rigidbody.velocity = new Vector2 (-MovimientoPelota.speed/2, MovimientoPelota.speed); //Si esta entre 0.5 y 0.75, se ira la izquierda arriba
		else if (random > 0.75 && random <= 1.00) ball.rigidbody.velocity = new Vector2 (-MovimientoPelota.speed/2, -MovimientoPelota.speed); //Si esta entre 0.75 y 1, se ira a la izquierda abajo
	}

}
