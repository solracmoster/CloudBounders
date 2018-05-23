using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CDestroy : MonoBehaviour {

	

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
         
        

        

		}



	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.name == "P1"){
           
            SceneManager.LoadScene("WinT");
        }
	}
}