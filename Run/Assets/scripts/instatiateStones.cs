using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instatiateStones : MonoBehaviour {

	public GameObject stone;

	float time=0f;

	float comparison=5f;

    GameObject selectedStone;


	//===============================================

	void Start(){
		

		for (int count=0;count<8;count++) {

				GameObject clone=Instantiate (stone, transform);

				transform.localPosition=new Vector3(15f,-0.01f,0f);

				 clone.SetActive(false);
			} 


		}

	//=========setting object state of stones to active============

		void FixedUpdate(){

		time = time + Time.fixedDeltaTime;


		int index = Random.Range (0, 8);

		selectedStone = transform.GetChild (index).gameObject;


		if (time >= comparison && selectedStone.activeSelf == false) {
			
			selectedStone.SetActive (true);

			comparison = Random.Range (3.5f,8f);

			time = 0f;

		}
	}

}
