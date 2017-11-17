using UnityEngine;
using System.Collections;

public class pressptostart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("p"))
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }
}
