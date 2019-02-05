using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceturnon : MonoBehaviour {

	void Awake () {
			
	}
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetString ("gameType") == "face") {
			gameObject.GetComponent<MeshRenderer> ().enabled = true;
			PlayerPrefs.SetString ("gameType", "");
		} else {
			gameObject.GetComponent<MeshRenderer> ().enabled = false;
			PlayerPrefs.SetString ("gameType", "");
		}
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(PlayerPrefs.GetString("gameType\t"));
	}
}
