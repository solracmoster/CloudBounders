using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpa : MonoBehaviour
{

    [Range(1, 20)]
    public float jumpVelocity;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        }
    }
}