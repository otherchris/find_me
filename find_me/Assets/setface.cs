﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setface : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (PlayerPrefs.GetString("gameState").ToString());
	}

	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Player")) {
			PlayerPrefs.SetString ("gameType", "face");
			Debug.Log ("turn on face");
		
		}
	}
}
