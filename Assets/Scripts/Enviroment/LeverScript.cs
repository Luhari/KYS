using UnityEngine;
using System.Collections;

public class LeverScript : MonoBehaviour {
    public bool activated = false;

    void Pull ()
    {
        
        this.activated = !this.activated;

        if (activated)
        {
            GetComponentInChildren<Animation>().Play("OpenDoor");
        }
        else
        {
            GetComponentInChildren<Animation>().Play("CloseDoor");
        }
    }
}
