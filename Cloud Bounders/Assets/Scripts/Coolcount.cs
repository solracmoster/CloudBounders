using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CoolCount : MonoBehaviour {

	// Use this for initialization
	float cooldowntimer;
	void Start () {
        cooldowntimer = PlayerPrefs.GetFloat ("cloud");
	}
	
	// Update is called once per frame
	void Update () {
        cooldowntimer = PlayerPrefs.GetFloat ("cloud");
		GetComponent<Text> ().text = "" + cooldowntimer;
	}
}
