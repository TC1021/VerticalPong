using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameScore : MonoBehaviour {
	public static int player1Score = 0;
	public static int player2Score = 0;

	public Text player1Text;
	public Text player2Text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		player1Text.text = "Player 1 (South): " + player1Score;
		player2Text.text = "Player 2 (North): " + player2Score;
	
	}

	public static void resetScore(){
		player1Score = 0;
		player2Score = 0;
	}
}
