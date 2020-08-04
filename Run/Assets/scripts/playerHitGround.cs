using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHitGround : MonoBehaviour {

	public playerMove runAgain;

	public GameObject stoneHolder;

	void OnCollisionEnter2D(Collision2D col){

		if(col.gameObject.tag=="Player" && stoneHolder.activeSelf==true )
		     runAgain.playerRun ();

    }

}
