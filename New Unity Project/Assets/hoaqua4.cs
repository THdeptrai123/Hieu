using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoaqua4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject != null)
        {
            Destroy(this.gameObject, 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
