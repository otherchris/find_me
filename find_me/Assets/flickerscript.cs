using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickerscript : MonoBehaviour {

	private Animator _animator;
	// Use this for initialization
	void Start () {
	    _animator = GetComponent<Animator> ();
		_animator.SetBool ("flicker", false);
	}
	
	void OnTriggerEnter(Collider other) {	
		Debug.Log ("slkjf");
		if (other.CompareTag("Player")) {
			_animator.SetBool ("flicker", true);

		}
	}
}
