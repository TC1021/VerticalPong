using UnityEngine;
using System.Collections;

public class Movement_North_Player : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.LeftArrow) && transform.position.x>-6.4f) 
		{
			GetComponent<Transform>().Translate ( new Vector2(-0.14f, 0) );
		}
		if (Input.GetKey (KeyCode.RightArrow) && transform.position.x<6.5f) 
		{
			GetComponent<Transform>().Translate ( new Vector2(0.14f, 0) );
		}
	}
}
