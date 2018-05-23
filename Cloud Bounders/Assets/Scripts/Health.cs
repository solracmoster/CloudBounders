using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour {

	// Use this for initialization
	public int health = 1;
	void Start () {
		PlayerPrefs.SetInt("Health", health);
	}
	
	// Update is called once per frame
	void Update () {
				if(PlayerPrefs.GetInt ("Health") <=0) {
					//reload the scene
					Scene scene = SceneManager.GetActiveScene();
					SceneManager.LoadScene ("Game");

	}
        //if (Input.GetKey("r"))
       // {
        //    SceneManager.LoadScene("Tutorial");
       // }
       // if (Input.GetKey("m"))
        //{
        //    SceneManager.LoadScene("MainMenu");
        //}
       // if (Input.GetKey("p"))
       // {
       //     SceneManager.LoadScene("Title");
        //}
    }
		void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.gameObject.tag == "Killer") {
			PlayerPrefs.SetInt ("Health", PlayerPrefs.GetInt ("Health") - 1);
            //Soundmanagerscript.PlaySound("Hurt");
        }

	
		if (collision.gameObject.tag == "Enemy") {
			PlayerPrefs.SetInt ("Health", PlayerPrefs.GetInt ("Health") - 1);
            //Soundmanagerscript.PlaySound("Hurt");
        }
	}
   // void OnTriggerEnter2D(Collider2D other)
    //{
     //   if (other.gameObject.tag == "HP")
     //   {
       //     PlayerPrefs.SetInt("Health", PlayerPrefs.GetInt("Health") + 1);
            //Soundmanagerscript.PlaySound("HTank");

       // }
    }
//}