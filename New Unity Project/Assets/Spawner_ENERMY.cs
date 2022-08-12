using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_ENERMY : MonoBehaviour
    
{
    public GameObject enermy;
    public float Radius = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) SpawobjectAtrandom();
    }
    void SpawobjectAtrandom()
    {
        Vector3 randomPos = Random.insideUnitCircle *  Radius;
        Instantiate(enermy, randomPos, Quaternion.identity);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position,Radius);
    }
}
