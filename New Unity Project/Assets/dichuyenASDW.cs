using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dichuyenASDW : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
        
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 5 *Time.deltaTime); // 5 là speed 
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 5 *Time.deltaTime);
        }


        if(Input.GetKey(KeyCode.A))
        {
           transform.Translate(Vector3.left * 5 *Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D))
        {
           transform.Translate(Vector3.right * 5 *Time.deltaTime);
        }

        
    }
}
