using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one_way_door : MonoBehaviour {

	MeshCollider wall;
	// Use this for initialization
	void Start () {
		wall = GetComponent<MeshCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			Destroy (wall);
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag("Player")) {
			wall = gameObject.AddComponent<MeshCollider>() as MeshCollider;
		}
	}
}
