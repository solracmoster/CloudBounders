using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public GameObject prefab;
    public float shootspeed = 10.0f;

    public float cooldown;
    public float cooldowntimer;



    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        
        if (cooldowntimer > 0)
        {
            cooldowntimer -= Time.deltaTime;
        }

        if (cooldowntimer < 0)
        {
            cooldowntimer = 0;
        }
        //if (Input.GetButtonDown ("Fire1")) {

        //fire ze missiles
        //Debug.Log ("Boom");


        //gets the mouse position pixels on the screen and this converts the mouse position from pixels to an x,y,z postion in the game
        //  var mousePosition = Input.mousePosition;
        //	mousePosition = Camera.main.ScreenToWorldPoint (mousePosition);
        //calculate shoot direction as the mouse position - the player position
        //	Vector2 shootDirection = new Vector2 (mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        //	shootDirection.Normalize ();

        //	Vector3 playerPosition = transform.position;
        //	playerPosition.x += shootDirection.x * 0.78f;
        //	playerPosition.y += shootDirection.y * 0.78f;

        //will create object in front of the player towards the mouse
        //	GameObject bullet = (GameObject) Instantiate(prefab, playerPosition, Quaternion.identity);
        //Shootnoise, remember to put an audiosource on the object
        // Soundmanagerscript.PlaySound("shootp");

        //   bullet.GetComponent<Rigidbody2D> ().velocity = shootDirection * shootspeed;
        //	Destroy (bullet, 0.4f);
        //}

    }


    public void BOOM()
    {

        if (cooldowntimer == 0) {

        var mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 shootDirection = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        shootDirection.Normalize();

        Vector3 playerPosition = transform.position;
        playerPosition.x += shootDirection.x * 0.78f;
        playerPosition.y += shootDirection.y * 0.78f;


        GameObject ECASPLOSION = (GameObject)Instantiate(prefab, playerPosition, Quaternion.identity);



        ECASPLOSION.GetComponent<Rigidbody2D>().velocity = shootDirection * shootspeed;

            cooldowntimer = cooldown;
    }
  }

}
