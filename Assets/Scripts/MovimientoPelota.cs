using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MovimientoPelota : MonoBehaviour {
	public static float speed = 5;
	public GameObject player1;
	public GameObject player2;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (InitiateBall ());
	}

	IEnumerator InitiateBall()
	{
		yield return new WaitForSeconds(3.0f);
		float random = Random.value;
		if (random <= 0.25) GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed/2, speed);
		else if (random > 0.25 && random <= 0.50) GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed/2, -speed);
		else if (random > 0.50 && random <= 0.75) GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed/2, speed);
		else if (random > 0.75 && random <= 1.00) GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed/2, -speed);
	}

	// Update is called once per frame
	void Update () {
		// restart the game
		if (Input.GetKey (KeyCode.R)) {
			GameScore.resetScore ();
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0);
			GetComponent<Rigidbody2D>().transform.position = new Vector2 (0, 0);
			player1.transform.position = new Vector2 (-0.05f, -2.78f);
			player2.transform.position = new Vector2 (-0.05f, 2.82f);
			StartCoroutine (InitiateBall ());
		}
	}
}
