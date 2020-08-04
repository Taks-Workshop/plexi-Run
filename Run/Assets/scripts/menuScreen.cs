using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScreen : MonoBehaviour {

	public float highestscore;

	public Text hsText;

	public GameObject loadText;

	// =================================================

	void Start () {

		highestscore = PlayerPrefs.GetFloat ("highScore");

		hsText.text = "highest Score: "+ highestscore.ToString("f1");

		
	}


	//========================================================

	public void loadMainScene(){

		loadText.SetActive (true);

		SceneManager.LoadScene("main");


	}

}
