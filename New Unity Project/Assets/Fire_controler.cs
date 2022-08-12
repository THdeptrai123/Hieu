using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_controler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject != null)
        {
            Destroy(this.gameObject, 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 10 * Time.deltaTime);
       
    }
}
