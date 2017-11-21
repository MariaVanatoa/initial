using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Choises : MonoBehaviour {
	private bool Poop;
	public string Info;

	private List<string[]> questions  = new List<string[]>();
	private List<int> answerOrder = new List<int>(new int[] {1,2,3,4});

	void DrawInfo() {
		Rect rect = new Rect(500, 100, 400, 200);
		Rect close = new Rect(600, 500, 200, 100);
		if(GUI.Button(close, "ATTACK")) {
			Poop = !Poop;
		}

		if (Poop) {
			GUI.Box(rect, Info);
			GUI.Label(new Rect(520, 110, 400, 30), questions[0][0]);
			if (GUI.Button(new Rect(520, 200, 100, 30), questions[0][answerOrder[0]])) {
				HandleAnswer(answerOrder[0]);
			}
			if (GUI.Button(new Rect(520, 250, 100, 30), questions[0][answerOrder[1]])) {
				HandleAnswer(answerOrder[1]);
			}
			if (GUI.Button(new Rect(780, 200, 100, 30), questions[0][answerOrder[2]])) {
				HandleAnswer(answerOrder[2]);
			}
			if (GUI.Button(new Rect(780, 250, 100, 30), questions[0][answerOrder[3]])) {
				HandleAnswer(answerOrder[3]);
			}
		}
	}

	private void HandleAnswer(int answer) {
		if (answer == 1) {
			//handle correct answer
			NextQuestion();
		}
		else {
			//handle wrong answer
		}
	}

	void OnGUI() {
		//this is just to protect from an empty list... you will need better win/lose conditions.
		if(questions.Count > 0) {
			DrawInfo();
		}
	}

	void Start() {
		// String order: question, correct, wrong, wrong, wrong
		questions.Add(new string[] { "What in the capital of France?", "Paris", "New York", "London", "Madrid" });
		questions.Add(new string[] { "Which of these is an amphibian?", "Frog", "Shark", "Lizard", "Hawk" });
		questions.Add(new string[] { "Which of these is an planet?", "Neptune", "Thor", "Pegasus", "Hera" });
		Shuffle(questions);
		Shuffle(answerOrder);
	}

	void NextQuestion() {
		questions.RemoveAt(0);
		Shuffle(answerOrder);
	}

	// Credit for this implementation of Fisher-Yates Shuffle
	// goes to grenade at http://stackoverflow.com/questions/273313/randomize-a-listt-in-c-sharp
	static readonly System.Random rng = new System.Random();
	public static void Shuffle<T>(IList<T> list) {
		int n = list.Count;
		while(n > 1) {
			n--;
			int k = rng.Next(n + 1);
			T value = list[k];
			list[k] = list[n];
			list[n] = value;
		}
	}
}