using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextController : MonoBehaviour {

	List<string> question = new List<string>() {"This is the first question", "This is second question", "This is a third question", "This is fourth question","Fift?"};
	List<string> correctAnswer = new List<string>() {"4","1","2","4","3"};

	public Transform resultObj;
	public static string selectedAnswer;
	public static string choiseSelected="n";
	public static int randQuestion = -1;

	// Use this for initialization
	void Start () {
		//GetComponent<TextMesh> ().text = question [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (randQuestion == -1)
		{
			randQuestion = Random.Range (0, 5);
		}
		if (randQuestion > -1) 
		{
			GetComponent<TextMesh> ().text = question [randQuestion];
		}
		//Debug.Log (question [randQuestion]);

		if (choiseSelected == "y")
		{
			choiseSelected = "n";
		}
			if (correctAnswer [randQuestion] == selectedAnswer)
			{
			//Debug.Log ("Correct!"+" " + randQuestion);
				resultObj.GetComponent<TextMesh>().text = "Correct!  Click Next to Continue" ;
			}
		}
	}
//}
