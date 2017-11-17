using UnityEngine;
using System.Collections;

public class PressurePlateScript : MonoBehaviour {

    public bool pressed = false;


    void OnCollisionEnter (Collision Col)
    {
        if(Col.gameObject.tag == "Player" && pressed==false)
        {
            GetComponentInChildren<Animation>().Play("OpenDoor");
            pressed = true;
        }
    }

}
