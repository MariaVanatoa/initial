using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {

	private ButtonController bLeft;
	private ButtonController bRight;
	private ButtonController bUp;
	private ButtonController bDown;
	private GameObject ball;
	public float speed = 0.1f;


	// Use this for initialization
	//työkalumetodi milla voimme hakea unitysta jotain
	void Start () {
		
		ball = GameObject.Find ("Ball");
		bLeft = GameObject.Find ("ButtonLeft").GetComponent<ButtonController> ();
		bUp = GameObject.Find ("ButtonUp").GetComponent<ButtonController> ();
		bRight = GameObject.Find("ButtonRight").GetComponent<ButtonController> ();
		bDown = GameObject.Find("ButtonDown").GetComponent<ButtonController> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (bLeft.GetButtonPressed ()) {
			ball.transform.Translate (-1*speed, 0, 0);
		}
		if (bRight.GetButtonPressed ()) {
			ball.transform.Translate (1*speed, 0, 0);
		}	
		if (bUp.GetButtonPressed ()) {
			ball.transform.Translate (0,1*speed, 0);
		}	
		if (bDown.GetButtonPressed ()) {
			ball.transform.Translate (0,-1*speed,0);
		}

		}
}
