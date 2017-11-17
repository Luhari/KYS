using UnityEngine;
using System.Collections;




public class DeadMovement : MonoBehaviour {
	

	public int jumpForce = 400;
	public bool isJumping;
    public bool FacingRight;

	public int velocidad = 9;

	void Start () {
		isJumping = false;
        FacingRight = true;

    }
	
	void Update () {


        if (Input.GetKey("d") || Input.GetKey("a"))
        {
            transform.Translate(0, 0, Time.deltaTime * velocidad);
            if (isJumping == false)
            {
                GetComponent<Animation>().Play("DeadRun");
                GetComponent<Animation>()["DeadRun"].speed = 2;
            }
        }else
        {
            GetComponent<Animation>().Play("DeadIddle");
            //GetComponent<Animation>()["DeadIddle"].speed = 2;
        }

        if (Input.GetKeyDown("a"))
        {
            if (FacingRight) { transform.Rotate(0, 180, 0); }
            FacingRight = false;

        }
        if (Input.GetKeyDown("d"))
        {
            if (!FacingRight) { transform.Rotate(0, 180, 0); }
            FacingRight = true;

        }

        if (Input.GetKey ("w")) {
            transform.Translate(0, Time.deltaTime*velocidad, 0);
            GetComponent<Animation>().Play("DeadIddle");
        }
	    if (Input.GetKey ("s"))
        {
            transform.Translate(0, -Time.deltaTime * velocidad, 0);
            GetComponent<Animation>().Play("DeadIddle");
        }
	}


}
