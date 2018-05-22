using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpa : MonoBehaviour
{
    private bool grounded = false;

    [Range(1, 20)]
    public float jumpVelocity;
    
    void Update()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        }
        Debug.Log(grounded);
    }

    public void GetButtonDown()
    {
        if (grounded)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = false;
        }
    }
}