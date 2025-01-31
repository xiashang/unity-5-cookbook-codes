﻿using UnityEngine;
using System.Collections;

public class CheckPoints : MonoBehaviour {
	private Vector3 respawnPosition;
	
	void Start (){
		respawnPosition = transform.position;
	}
	
	void OnTriggerEnter (Collider hit){
		if(hit.CompareTag("CheckPoint")){
			respawnPosition = transform.position;
		}
		
		if(hit.CompareTag("Death")){
			transform.position = respawnPosition;
		}
	}
}
