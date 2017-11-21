using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour {
	public Transform resultObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		//TextController. = "n";
	//TextController.resultObj.GetComponent<TextMesh>().text = "????" ;
		resultObj.GetComponent<TextMesh>().text = "Continue" ;
	}
}
