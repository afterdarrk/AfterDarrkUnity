using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private SpriteRenderer spriteR;
	private bool selected;

	public Sprite idleSprite;
	public Sprite selectedSprite;

	// Use this for initialization
	void Start () {
		spriteR = gameObject.GetComponent<SpriteRenderer> ();
		spriteR.sprite = idleSprite;
		selected = false;
	}
	
	// Update is called once per frame
	void Update () {
		// Screen Touch
		if (Input.GetMouseButtonDown(0)) {

			Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D coll = GetComponent<Collider2D>();

			if (coll.OverlapPoint (touchPos)) {
				if (selected) {
					spriteR.sprite = idleSprite;
				} else {
					spriteR.sprite = selectedSprite;
				}

				selected = !selected;
			}
		}
	}
}
