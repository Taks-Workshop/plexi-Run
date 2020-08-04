using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	public GameObject retryPanel;

	public groundMove[] playGame;

	public GameObject stoneHolder;

	public AudioSource playerTripped;

	public scoring scoreBoard;

	AudioSource runSound;

	Animator playerAnim;


	//==========================================

	void Start(){

		runSound = GetComponent<AudioSource> ();

		playerRun ();

	}

	//=========================================

	void OnTriggerEnter2D(Collider2D col){

		if (col.tag == "stones") {

			scoreBoard.haltScoring = true;

			playerAnim.SetInteger ("playerState",-1);

			col.transform.localPosition=new Vector3(15f,-2.86f,0f);

			retryPanel.SetActive (true);

			pressPlay(false);

			playerTripped.Play ();

		}

	}

	//==========================================

	public void playerRun(){

		playerAnim = GetComponent<Animator> ();

		playerAnim.SetInteger ("playerState", 0);

		runSound.Play();

	}

	//===================================================

	public void pressPlay(bool state){

		stoneHolder.SetActive (state);

		runSound.enabled = state;

		foreach(groundMove pgScript in playGame){

			pgScript.enabled = state;

		}

	}

		
}
