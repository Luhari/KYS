using UnityEngine;
using System.Collections;

public class Enemy1script : MonoBehaviour {

    public int velocity = 10;
    public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Vector3.Distance(transform.position, player.position) < 10)
        {
            transform.LookAt(player);
            transform.Translate(Vector3.forward*Time.deltaTime*velocity);
        }
	}
}
