﻿using UnityEngine;
using System.Collections;

public class Player_Damage : MonoBehaviour {

	//Public Instances
	public int minusFullDmg=3;
	public int lifeValue=3;

	//Private Instances
	private Player_Collider playerCollider; 

	// Use this for initialization
	void Start () {
		GameObject playerColliderObject = GameObject.FindWithTag("Player"); // allows us to pull LifeCheck Method from the player collider script
		if (playerColliderObject != null)
		{
			playerCollider = playerColliderObject.GetComponent<Player_Collider>();
		}
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D otherCollider){
		if (otherCollider.gameObject.CompareTag ("Player")) { 	//Spike Trigger, if its a player then ..
			playerCollider.LifeCheck (minusFullDmg); // minus 3 life for spike damage 
		}
	}
}
