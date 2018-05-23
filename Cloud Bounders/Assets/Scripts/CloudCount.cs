using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CloudCount : MonoBehaviour {

	// Use this for initialization
	int cloud;
	void Start () {
		cloud = PlayerPrefs.GetInt ("cloud");
	}
	
	// Update is called once per frame
	void Update () {
		cloud = PlayerPrefs.GetInt ("cloud");
		GetComponent<Text> ().text = "" + cloud;
	}
}
