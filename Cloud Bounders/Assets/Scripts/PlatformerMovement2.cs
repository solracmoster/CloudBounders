using UnityEngine;
using System.Collections;


public class PlatformerMovement2 : MonoBehaviour {

	// Use this for initialization
	public float moveSpeed = 1.0f;
	public float jumpSpeed = 1.0f;
	private bool grounded = false;
 
	void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
		var moveX = Input.GetAxis ("Horizontal");
		var velocity = gameObject.GetComponent<Rigidbody2D> ().velocity;
		velocity.x = moveX * moveSpeed;
		gameObject.GetComponent<Rigidbody2D> ().velocity = velocity;

		if (Input.GetButtonDown ("Jump") && grounded) {
			gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 100 * jumpSpeed));
            //gameObject.GetComponent<AudioSource>().Play();
        }

        
    }

    public void GetButtonDown()
    {
        if (grounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
        }
    }


    void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.layer == 8) {
			grounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D collision){
		if (collision.gameObject.layer == 8) {
			grounded = false;
		}
	}

    public void Jump(float speed){
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
    }
    
}
