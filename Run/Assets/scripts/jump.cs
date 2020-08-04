using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class jump : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {

	public Animator playerAnim;

	public GameObject player;

    AudioSource effort;

	//====================================================

	void Start(){

		effort = GetComponent<AudioSource> ();


	}


	//=======================================================

	public virtual void OnPointerDown(PointerEventData pep){

		playerAnim.SetInteger ("playerState",1);

		playerJump ();

		effort.Play ();



	}

	//=========================================================

	public virtual void OnPointerUp(PointerEventData pep){


		//playerAnim.SetInteger ("playerState",0);


	}

	//=======================================================

	void playerJump(){

		player.transform.Translate (Vector3.up * 4.2f);


	}
		
}
