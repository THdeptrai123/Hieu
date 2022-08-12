using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DANROI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 30 * Time.deltaTime);
    }
}
