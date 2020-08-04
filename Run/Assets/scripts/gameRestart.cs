using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameRestart : MonoBehaviour {

	public scoring scoreKeeper;

	public playerMove startRun;

	public Transform stonesHolder;

	public playerMove playGame;

	bool setHighScore=false;


	//==================================================

	void Update(){

		if (scoreKeeper.hsReached == true && setHighScore==false) {
			
			PlayerPrefs.SetFloat ("highScore", float.Parse(scoreKeeper.scoreText.text));

			setHighScore = true;

		}

	}


	//===================================================

	public void retryGame(){

		scoreKeeper.score = 0.0f;

		setHighScore = false;

		scoreKeeper.haltScoring = false;

		scoreKeeper.hsReached = false; 

		scoreKeeper.hsText.text = PlayerPrefs.GetFloat ("highScore").ToString("f1");

		disableAllStones ();

		playGame.pressPlay(true);

		startRun.playerRun ();

		gameObject.SetActive (false);

	}


	//===================================================

	public void quitGame(){

		Application.Quit();

	}


	//==================================================
	void disableAllStones(){

		for(int i=0;i<8;i++){

			stonesHolder.GetChild (i).gameObject.SetActive (false);

		}


	}

}
