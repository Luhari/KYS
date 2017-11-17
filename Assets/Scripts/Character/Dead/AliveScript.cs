using UnityEngine;
using System.Collections;

public class AliveScript : MonoBehaviour {

    public float time = 3.5f;
    public Transform AliveChar;
    public Transform SpawnPoint;
    public GameObject[] GhostWalls;

    void Start()
    {
        StartCoroutine(Wait());

    }


    void Update()
    {





    }
    IEnumerator Wait() {

        GhostWalls = GameObject.FindGameObjectsWithTag("GhostWall");

        for (int i = 0; i < GhostWalls.Length; i++)
        {
            GhostWalls[i].SendMessage("Disable");
        }

        
        yield return new WaitForSeconds(time);
        for (int j = 0; j < GhostWalls.Length; j++)
        {     
            GhostWalls[j].SendMessage("Enable");
        }
        Instantiate(AliveChar, SpawnPoint.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

}