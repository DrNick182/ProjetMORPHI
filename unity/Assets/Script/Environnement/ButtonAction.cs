﻿using UnityEngine;
using System.Collections;

public class ButtonAction : MonoBehaviour {


	public Material buttonBasOk;//texture quand le button est appuyé
	public MeshRenderer buttonBas;//Mesh renderer component du game object button bas

	public string tagButton;
	public string tagPorte;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void destroyCollider(){

		GameObject button = GameObject.FindGameObjectWithTag(tagButton);
		GameObject objetSmash = button.transform.GetChild(2).gameObject;

		Collider smashColl = objetSmash.GetComponent<Collider> ();
		smashColl.enabled = false;


		GameObject porte = GameObject.FindGameObjectWithTag(tagPorte);
		AnimationPorteButton scriptAnimPorte = porte.GetComponent<AnimationPorteButton>();

		bool etatButton = scriptAnimPorte.buttonOK;
		etatButton = true;
		scriptAnimPorte.buttonOK = true;

		buttonBas.material = buttonBasOk;


	}
}
