using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour {

	float highestScore=0f;

	public float score;

	public Text hsText;

	public Text scoreText;

	public bool hsReached=false;

	public bool haltScoring = false;

	float time;

	//====================================================

	void Start(){

		highestScore = PlayerPrefs.GetFloat ("highScore");

		hsText.text = highestScore.ToString ("f1");

	}

	//=====Update score label && check if highest score has been reached==========

	void FixedUpdate(){

		time = time + Time.fixedDeltaTime;

		if (score > PlayerPrefs.GetFloat ("highScore") && hsReached == false) {  // optioned to use playerprefs as to not lose HS on restart
			 
			hsText.text = "New High Score!";

			hsReached = true;

		}

		if (time >= 2.5f && haltScoring==false) {
			
			score = score + 0.1f;

			scoreText.text=score.ToString ("f1");

			time = 0f;
		}			

	}

}
