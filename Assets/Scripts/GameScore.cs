//Gualberto Casas - A00942270
//Seung Hoon Lee Kim - A01021720
//Ruben Cuadra

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameScore : MonoBehaviour {
	public static int player1Score = 0; //Un int en el que comienze en 0, en este int se iran guardando los puntos del jugador 1
	public static int player2Score = 0; //Un int en el que comienze en 0, en este int se iran guardando los puntos del jugador 2

	public Text player1Text; //El texto en el que se ira guardando en el GUI el indicador del jugador 1 y sus puntos 
	public Text player2Text; //El texto en el que se ira guardando en el GUI el indicador del jugador 2 y sus puntos 

	// Use this for initialization
	void Start () 
	{
	}

	// Update is called once per frame
	void Update () 
	{
		player1Text.text = "Player 1 (South): " + player1Score; //Aqui asignamos lo que se ira viendo en el player1Text, y le agregamos el int player1Score que se ira cambiando dependiendo de los puntos que ganen
		player2Text.text = "Player 2 (North): " + player2Score;
	}

	public static void resetScore()
	{
		player1Score = 0; //Score del jugador 1 = 0
		player2Score = 0; //Score del jugador 2 = 0
	}
}
