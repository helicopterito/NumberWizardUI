using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	private int MAX;
	private int MIN;
	private int guess;
	public int MAX_GUESSES_ALLOWED = 5;

	public Text text;

	// Use this for initialization
	void Start () {
		StartGame ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GuessHigher(){
		MIN = guess;
		NextGuess ();
	}

	public void GuessLower(){
		MAX = guess;
		NextGuess ();
	}

	void StartGame(){
		MAX = 1000;
		MIN = 0;
		NextGuess ();
	}

	void NextGuess(){
		guess = Random.Range(MIN, MAX+1);
		text.text = guess.ToString();
		MAX_GUESSES_ALLOWED--;

		if (MAX_GUESSES_ALLOWED <= 0) {
			SceneManager.LoadScene ("Win");
		}
	}
}
