﻿using UnityEngine;
using System.Collections;

public class ButtonAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void destroyCollider(){

		GameObject button = GameObject.FindGameObjectWithTag("Button_Porte2");
		GameObject objetSmash = button.transform.GetChild(2).gameObject;

		Collider smashColl = objetSmash.GetComponent<Collider> ();
		smashColl.enabled = false;


		GameObject porte = GameObject.FindGameObjectWithTag("Porte2");
		AnimationPorteButton scriptAnimPorte = porte.GetComponent<AnimationPorteButton>();

		bool etatButton = scriptAnimPorte.buttonOK;
		etatButton = true;
		scriptAnimPorte.buttonOK = true;
		//Collider smashColl = //Debug.Log (smashColl);
		//Debug.Log(button.transform.FindChild("Smash_Collider").gameObject);
	}
}
