using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class add_remove_wall : MonoBehaviour {

	MeshCollider wall;
	// Use this for initialization
	void Start () {
		wall = GetComponent<MeshCollider> ();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			Debug.Log ("enter");
			Destroy (wall);
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player")) {
			Debug.Log ("exit");
			wall = gameObject.AddComponent<MeshCollider>() as MeshCollider;
		}
	}
}
