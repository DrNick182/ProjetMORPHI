﻿using UnityEngine;
using System.Collections;

public class ColliderEnemmie : MonoBehaviour {


	public Animation animEnnemie;

	public GestionEtat joueurEtat;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter(Collider monCollider){

		if (monCollider.gameObject.tag == "Joueur" && joueurEtat.etatActif == GestionEtat.Etat.Solide) {

			//Debug.Log (joueurEtat.etatActif);
			animEnnemie.Play ();
		}
			
	}

}
