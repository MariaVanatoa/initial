﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour {

	void OnGUI()
	{
		if (GUI.Button (new Rect (50,145, 150, 30), "Play"))
			SceneManager.LoadScene ("EngineRoom", LoadSceneMode.Single);
		if (GUI.Button(new Rect (50,185, 150, 30), "Quit Game"))
			SceneManager.LoadScene ("QuitGame", LoadSceneMode.Single);
}
	/*void Update () {
		
	}
		void QuitGame () {
			Application.Quit ();
			Debug.Log("Game is exiting");
		}*/
} 
 