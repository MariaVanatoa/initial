using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}


	void OnCollisionEnter2D (Collision2D col) {
		//rb.AddForce (new Vector2 (-5F,0));
		//Destroy (col.gameObject);
		//gameObject.transform.Translate (-2F, 0, 0);
	}


	// Update is called once per frame
	void Update () {

	}
}


