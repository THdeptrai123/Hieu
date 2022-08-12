using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_Control : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

    }

    public GameObject fire;
    int speed = 5;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(fire, transform.position, Quaternion.identity);
            transform.Translate(Vector3.right * 5 * Time.deltaTime);
        }
    }
}

