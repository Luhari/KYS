﻿using UnityEngine;
using System.Collections;

public class NextLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }
}
