using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text3 : MonoBehaviour {
	List<string> thirdchoice = new List<string>() {"First choice"," Second","Third","Fourth", "Fift"};
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (TextController.randQuestion > -1) 
		{
			GetComponent<TextMesh> ().text = thirdchoice [TextController.randQuestion];
		}
	}
	void OnMouseDown()
	{
		//Debug.Log (gameObject.name);
		TextController.selectedAnswer = gameObject.name;
		TextController.choiseSelected = "y";
	}
}
