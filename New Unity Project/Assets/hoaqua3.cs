using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoaqua3 : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask Layer;
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
