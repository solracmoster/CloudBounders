﻿using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
		void Update() {
			if (Input.GetKey("escape"))
				Application.Quit();

		}
	}