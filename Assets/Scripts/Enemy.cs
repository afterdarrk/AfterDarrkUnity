using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	private static Enemy selectedEnemy;

	private SpriteOutline spriteOutline;
	private Collider2D enemyCollider;

	public float speed = 1.0f;
	public GameObject target;

	// Use this for initialization
	void Start () {
		spriteOutline = GetComponent<SpriteOutline> ();
		enemyCollider = GetComponent<Collider2D> ();

		spriteOutline.enabled = false;

        Vector3 moveDirection = target.transform.position - transform.position;
        float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
	
	// Update is called once per frame
	void Update () {
        // Screen Touch
        if (Input.GetMouseButtonDown (0)) {
			Vector3 touchPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

			if (enemyCollider.OverlapPoint (touchPos)) {
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

		if (target != null) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, target.transform.position, step);
		}
	}
}
