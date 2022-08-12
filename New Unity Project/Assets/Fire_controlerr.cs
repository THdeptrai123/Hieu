using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_controlerr : MonoBehaviour
{
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
        transform.Translate(Vector3.right * 5 * Time.deltaTime);

    }
}
