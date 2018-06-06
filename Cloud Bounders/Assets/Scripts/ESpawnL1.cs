using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESpawnL1 : MonoBehaviour {

    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    public float nextSpawn = 0.0f;

    void Start()
    {
        
    }

   void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(35.0f, 53.0f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}