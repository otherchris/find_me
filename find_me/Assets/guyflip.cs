using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guyflip : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			gameObject.transform.eulerAngles = new Vector3(
				gameObject.transform.eulerAngles.x,
				90,
				gameObject.transform.eulerAngles.z
			);
		}
	}
}
