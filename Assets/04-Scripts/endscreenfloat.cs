using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class endscreenfloat : MonoBehaviour 
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject belliot;
    public GameObject lelliot;
    public GameObject jake;
    public GameObject saunder;
    public GameObject cyle;

    public Rigidbody rb;


    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        if(MainManager.Instance.belliotPick)
        {
            GameObject obj = Instantiate(belliot, new Vector3(12, 35, 16), Quaternion.identity);
            obj.GetComponent<Rigidbody>().velocity = new Vector3(-100,0,0);

        }

        if(MainManager.Instance.lelliotPick)
        {
            GameObject obj = Instantiate(belliot, new Vector3(12, 35, 16), Quaternion.identity);
            obj.GetComponent<Rigidbody>().velocity = new Vector3(-100,0,0);
        }

        if(MainManager.Instance.jakePick)
        {
            Instantiate(jake, new Vector3(13, 0, 25), Quaternion.identity);
            rb = jake.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(-5, 0, 0);
        }

        if(MainManager.Instance.saunderPick)
        {
            Instantiate(saunder, new Vector3(13, 0, 25), Quaternion.identity);
            rb = saunder.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(-5, 0, 0);
        }

        if(MainManager.Instance.cylePick)
        {
            Instantiate(cyle, new Vector3(13, 0, 25), Quaternion.identity);
            rb = cyle.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(-5, 0, 0);
        }
    }
}