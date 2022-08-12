using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycontroler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject firepoint;
    public LayerMask mask;
    private float speed;
    public RaycastHit2D Layer;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float step = speed * Time.deltaTime;
        
        //transform.position = Vector3.MoveTowards(transform.position,target.position,step);
    }
    private void FixedUpdate()
    {
        // b1: lay ra toa do bat dau 
        Vector2 startP = new Vector2(firepoint.transform.position.x, firepoint.transform.position.y);
        // b2: lay ra toa do ket thuc
        Vector2 endP = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        // b3:  khoi tao raycast (duong dan)
        RaycastHit2D hit2D = Physics2D.Raycast(startP, (endP - startP), 20, mask);
        // b4 kiem tra va cham
        //Debug.DrawLine(startP, (startP - endP) * 100, Color.cyan)
            Debug.DrawLine(startP,endP, Color.cyan);
        if (hit2D.collider !=null)
        {
            Debug.Log(hit2D.collider.name);
        }
        else
        {
            Debug.Log("no hits");
        }
    }
}
