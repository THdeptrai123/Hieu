using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieukhiennhanvat : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.SetInteger("trangthai",1);
        }
         if(Input.GetKeyDown(KeyCode.S))
        {
            animator.SetInteger("trangthai",4);
        }
         if(Input.GetKeyDown(KeyCode.D))
        {
            animator.SetInteger("trangthai",2);
        }
         if(Input.GetKeyDown(KeyCode.F))
        {
            animator.SetInteger("trangthai",3);
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            animator.SetInteger("trangthai",5);
        }
    }
}
