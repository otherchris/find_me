﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class facedisable : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<MeshRenderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(PlayerPrefs.GetString("gameState"));
	}
}
