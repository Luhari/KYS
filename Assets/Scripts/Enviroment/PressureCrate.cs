using UnityEngine;
using System.Collections;

public class PressureCrate : MonoBehaviour
{

    public bool pressed = false;
    public Transform boxholder;
    public Transform rope;


    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "Player" && pressed == false)
        {
            Destroy(boxholder.gameObject);
            Destroy(rope.gameObject);
        }
    }
}

