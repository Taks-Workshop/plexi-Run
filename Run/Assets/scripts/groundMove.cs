using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class groundMove : MonoBehaviour {

	float groundSpeed=-0.1f;

	//====moves ground_sky to starting position=========

	void OnTriggerEnter2D(Collider2D col){
		
		if (col.tag == "obstacle" && gameObject.tag=="stones") 		
			transform.localPosition=new Vector3(15f,-2.86f,0f);


		if (col.tag == "obstacle" && gameObject.tag=="ground") 					
			transform.localPosition = new Vector3 (25f, 0f, 0f); 
	

	}


	//===============================================

		void FixedUpdate(){

		        transform.Translate (Vector3.right*groundSpeed);

	}

		
}
