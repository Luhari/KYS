using UnityEngine;
using System.Collections;

public class deWalls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void Disable()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }
    void Enable()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
