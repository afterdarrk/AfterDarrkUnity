using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private SpriteOutline spriteOutline;

	// Use this for initialization
	void Start () {
		spriteOutline = GetComponent<SpriteOutline> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Screen Touch
		if (Input.GetMouseButtonDown(0)) {
			Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D coll = GetComponent<Collider2D>();

			if (coll.OverlapPoint (touchPos)) {
				spriteOutline.enabled = !spriteOutline.enabled;
			}
		}
	}
}
