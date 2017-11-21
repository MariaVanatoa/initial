using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextController : MonoBehaviour {

	public string question = "This is the first question";
	public string[] answers = new string[4];
	public int correct = 0;

	public TextMesh[] fields; 

	// Use this for initialization
	void Start () {
		GetComponent<TextMesh> ().text = question;

		for (int i = 0; i < answers.Length; i++) {
			fields [i].text = answers [i];
			fields [i].gameObject.name = "" + i;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Answer(string name) {
		if (int.Parse (name) == correct) {
			Debug.Log ("Oikein!");
		} else {
			Debug.Log ("Väärin!");
		}
	}
}
