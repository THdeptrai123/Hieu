using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOMERANG : MonoBehaviour
{
    // Start is called before the first frame update
    bool go;
    GameObject player;
    GameObject fire;
    Transform itemToRotate;
    Vector3 locationInFrontOfPlayer;
    void Start()
    {
        go = false;
        player = GameObject.Find("Player");
        fire = GameObject.Find("fire");
        fire.GetComponent<MeshRenderer>().enabled = false;
        itemToRotate = gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
