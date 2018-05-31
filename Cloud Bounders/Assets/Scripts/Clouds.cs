using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Clouds : MonoBehaviour {

	// Use this for initialization
	public int cloud = 1;
	void Start () {
		PlayerPrefs.SetInt("cloud", cloud);
	}
	
	// Update is called once per frame
	void Update () {
				//if(PlayerPrefs.GetInt ("cloud") <=0) {
					//reload the scene
				//	Scene scene = SceneManager.GetActiveScene();
				//	SceneManager.LoadScene ("");

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
    
		//void OnCollisionEnter2D (Collision2D collision)
	//{
		///if (collision.gameObject.tag == "Killer") {
		//	PlayerPrefs.SetInt ("Health", PlayerPrefs.GetInt ("Health") - 1);
            //Soundmanagerscript.PlaySound("Hurt");
       // }

	
		//if (collision.gameObject.tag == "lazer") {
		//	PlayerPrefs.SetInt ("Health", PlayerPrefs.GetInt ("Health") - 1);
            //Soundmanagerscript.PlaySound("Hurt");
       // }
	//}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "cloud")
        {
        PlayerPrefs.SetInt("cloud", PlayerPrefs.GetInt("cloud") + 1);
            Debug.Log(cloud);
        //Soundmanagerscript.PlaySound("HTank");

    }
    }
}