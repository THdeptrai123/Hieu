using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class END_DEADANIMATION : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject != null)
        {
            Destroy(this.gameObject, 0.3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
