using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESpawn : MonoBehaviour {

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
            randX = Random.Range(-8.4f, 8.4f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}