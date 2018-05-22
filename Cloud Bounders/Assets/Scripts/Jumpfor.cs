using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpfor : MonoBehaviour
{

    [Range(1, 20)]
    public float fwrdVelocity;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * fwrdVelocity;
        }
    }
}