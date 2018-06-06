using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESpawn1 : MonoBehaviour {

    public GameObject enemy;
    float randX;
    float randY;
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
            randY = Random.Range(-54.0f, -70.0f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}