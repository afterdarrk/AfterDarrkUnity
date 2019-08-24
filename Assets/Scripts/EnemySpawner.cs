using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    private int lastProbChance;

    [Range(0, 1)]
    public float probability;
    public float spawnDelay;
    public Enemy enemy;
    public bool spawningEnabled;

	// Use this for initialization
	void Start () {
        lastProbChance = (int) Time.time;
    }
	
	// Update is called once per frame
	void Update () {
		if (Time.time > lastProbChance + spawnDelay && spawningEnabled) {
            Debug.Log("Chance " + probability);
            if (Random.value < probability) {
                Debug.Log("Spawning the enemy");
                Instantiate(enemy, transform.position, Quaternion.identity);
            }

            lastProbChance = (int) Time.time;
        }
    }
}
