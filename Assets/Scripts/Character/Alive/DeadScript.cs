using UnityEngine;
using System.Collections;

public class DeadScript : MonoBehaviour {

    public int Health;
    public Transform DeadChar;

    void Start () {
        Health = 100;
	}
	

	void Update () {
	    if (Health <= 0)
        {
            Instantiate(DeadChar, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }




	}

    void TakeDamage (int Damage)
    {
        Health -= Damage;
    }
}
