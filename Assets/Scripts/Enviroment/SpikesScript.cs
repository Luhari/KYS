using UnityEngine;
using System.Collections;

public class SpikesScript : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

    void OnCollisionEnter (Collision Coll)
    {
        if (Coll.gameObject.tag == "Player")
        {
            Coll.gameObject.SendMessage("TakeDamage", 100);
        }
    }
}
