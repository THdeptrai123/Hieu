using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword_Controler : MonoBehaviour
{
    // Start is called before the first frame update
    bool facingRight;
    void Start()
    {
        facingRight = true;
    }

    // Update is called once per frame
    public GameObject Firer;
    public GameObject Firer2;

    void Update()

    {
        float move = Input.GetAxis("Horizontal");
        int direction = 0;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 5 * Time.deltaTime);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 5 * Time.deltaTime);
        }


        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            // characterScale.x = -4;
            
            direction = 0;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            //   characterScale.x = 4;
            
            direction = 1;
        }
        transform.localScale = characterScale;


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 5 * Time.deltaTime);
            
            if (move > 0 && !facingRight)
            {
                flip();
             

            }
            else if (move < 0 && facingRight)
            {
                flip();
               

            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 5 * Time.deltaTime);
           
            if (move > 0 && !facingRight)
            {
                flip();
                
            }
            else if (move < 0 && facingRight)
            {
                flip();
           
            }
        }
       
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (direction == 1)
            {
                Instantiate(Firer, transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(Firer2, transform.position, Quaternion.identity);
            }

        }
    }
    // if (Input.GetKeyDown(KeyCode.K))
    // {
    //    Instantiate(Firer, Vector3.forward, Quaternion.identity);
    //
    // }

    //  }
    void flip()
    {
        facingRight = !facingRight;
        Vector3 thescale = transform.localScale;
        thescale.x *= -1;
        transform.localScale = thescale;
    }
}
    
    

