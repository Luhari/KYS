using UnityEngine;
using System.Collections;

public class restartlevel : MonoBehaviour {


	void Update () {

        if (Input.GetKeyDown("r"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        

    }


}
