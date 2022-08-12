using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healbarrcontroler : MonoBehaviour
{
    // Start is called before the first frame update
    Slider sli;
    void Start()
    {
        sli = GetComponent<Slider>();
        sli.value = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
