using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUADAN : MonoBehaviour
{ 
void Start()
    {

    }

int count = 150, a = 1, direction = 0, speed = 10;

    public GameObject bullet3;
    // Update is called once per frame
    void Update()
{
    if (Input.GetKeyDown(KeyCode.Return))
    {
       Instantiate(bullet3, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
       
        }
}
}

