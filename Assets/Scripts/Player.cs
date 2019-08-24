using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		// Closes the application (Note: in unity editor nothing happens)
		Destroy (col.gameObject);
		Debug.Log("Closing Application");
	}
}
