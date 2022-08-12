using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomerangg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    int degrees = -3, direction = 1, countDown = 100;

    // Update is called once per frame
    void Update()
    {
        countDown--;
        if (countDown == 0) direction = 0;
        transform.Rotate(Vector3.forward * degrees);
        if (direction == 1)
        {
            gameObject.transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
        }
        else
        {
            gameObject.transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
        }
    }
}
