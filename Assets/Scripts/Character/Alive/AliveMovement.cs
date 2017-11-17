using UnityEngine;
using System.Collections;




public class AliveMovement : MonoBehaviour {
	

	public int jumpForce = 350;
	public bool isJumping;
    public bool FacingRight;

    public int velocidad = 8;
	// Use this for initialization
	void Start () {
		isJumping = false;
        FacingRight = true;

    }
	
	// Update is called once per frame
	void Update () {

       if (!Input.anyKey && !isJumping ){
           GetComponent<Animation>().Play("Iddle01");
       }

        



        if (Input.GetKey ("d") || Input.GetKey("a"))
        {
			transform.Translate(0, 0, Time.deltaTime*velocidad);
            if (isJumping == false)
            {
                GetComponent<Animation>().Play("Running");
                GetComponent<Animation>()["Running"].speed = 3;
            }
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


        if (Input.GetKey("w") && !isJumping)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
            isJumping = true;
            GetComponent<Animation>().Play("Jump");
            GetComponent<Animation>()["Jump"].speed = 1.5f;
        }



        if (Input.GetKeyDown("e"))
        {

            GetComponent<Animation>().Stop("Iddle01");
            GetComponent<Animation>().Play("PullLever");

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                if (hit.collider.gameObject.tag == "lever") //&& hit.distance < 1)
                {
                    Debug.Log("Pressed");
                    hit.collider.gameObject.SendMessage("Pull");
                }

            }
            
        }





    }


	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.tag == "Ground") {
			isJumping = false;
		}
	}
}
