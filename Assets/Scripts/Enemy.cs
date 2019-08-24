using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private static Enemy selectedEnemy;

	private SpriteOutline spriteOutline;

	// Use this for initialization
	void Start () {
		spriteOutline = GetComponent<SpriteOutline> ();
		spriteOutline.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		// Screen Touch
		if (Input.GetMouseButtonDown(0)) {
			Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D coll = GetComponent<Collider2D>();

			if (coll.OverlapPoint (touchPos)) {
				if (selectedEnemy != null) {
					selectedEnemy.spriteOutline.enabled = false;
				}

				if (selectedEnemy == this) {
					selectedEnemy = null;
				} else {
					selectedEnemy = this;
					spriteOutline.enabled = true;
				}
			}
		}
	}
}
