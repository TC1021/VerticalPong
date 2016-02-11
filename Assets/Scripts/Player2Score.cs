using UnityEngine;
using System.Collections;

public class Player2Score : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;

	void OnCollisionEnter2D(Collision2D ball)
	{
		GameScore.player2Score += 10;
		ball.transform.position = new Vector2 (0, 0);
		player1.transform.position = new Vector2 (-0.05f, 2.82f);
		player2.transform.position = new Vector2 (-0.05f, -2.78f);
		ball.rigidbody.velocity = new Vector2 (0, 0);
		StartCoroutine (InitiateBall (ball));
	}
		
	IEnumerator InitiateBall(Collision2D ball)
	{
		MovimientoPelota.speed = 5;
		yield return new WaitForSeconds(2.0f);
		float random = Random.value;
		if (random <= 0.25) ball.rigidbody.velocity = new Vector2 (MovimientoPelota.speed/2, MovimientoPelota.speed);
		else if (random > 0.25 && random <= 0.50) ball.rigidbody.velocity = new Vector2 (MovimientoPelota.speed/2, -MovimientoPelota.speed);
		else if (random > 0.50 && random <= 0.75) ball.rigidbody.velocity = new Vector2 (-MovimientoPelota.speed/2, MovimientoPelota.speed);
		else if (random > 0.75 && random <= 1.00) ball.rigidbody.velocity = new Vector2 (-MovimientoPelota.speed/2, -MovimientoPelota.speed);
	}

}
