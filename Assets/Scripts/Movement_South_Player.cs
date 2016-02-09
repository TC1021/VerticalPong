using UnityEngine;
using System.Collections;

public class Movement_South_Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) 
		{
			GetComponent<Transform>().Translate ( new Vector2(-0.2f, 0) );
		}
		if (Input.GetKey (KeyCode.S)) {
			GetComponent<Transform>().Translate ( new Vector2(0.2f, 0) );
		}
	}
}
