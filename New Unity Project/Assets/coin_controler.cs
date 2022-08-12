using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_controler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject coin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)

    {

        if (collision.gameObject.tag.Equals("bullet"))

        {

             Destroy(collision.gameObject);

           // Destroy(gameObject);

            Instantiate(coin, collision.gameObject.transform.position, Quaternion.identity);
          
        }

    }
}
