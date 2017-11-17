using UnityEngine;
using System.Collections;

public class Lever2Script : MonoBehaviour {

    public bool activated = false;

    public Transform Elevator;
    void Pull()
    {

        this.activated = !this.activated;

        if (activated)
        {
            Elevator.GetComponent<Animation>().Play("Elevator1");
        }
        else
        {

        }
    }
}
