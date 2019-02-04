using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoton : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter(Collider other) {	
		if (other.CompareTag("Player")) {
			Debug.Log ("in");
			GetComponent<Light> ().intensity = 5;
		}
	}
}