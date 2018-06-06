using UnityEngine;
using System.Collections;

public class EnemyHealth1 : MonoBehaviour {

	public int health = 1;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(health <= 0) {
         
            Destroy(this.gameObject);

        }

		}



	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.name == "Nembus"){
			//when the player runs into an enemy reduce the players health
			health--;
            //Soundmanagerscript.PlaySound("EHurt");
        }
	}
     void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.tag == "BOOm")
       {
            health--;
            //Soundmanagerscript.PlaySound("HTank");

        }
   }
}