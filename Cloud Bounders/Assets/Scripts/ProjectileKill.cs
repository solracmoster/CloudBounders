﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileKill : MonoBehaviour {

    public float Hakai;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(this.gameObject, Hakai);
    }
}
