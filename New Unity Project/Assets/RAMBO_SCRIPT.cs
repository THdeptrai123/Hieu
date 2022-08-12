using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAMBO_SCRIPT : MonoBehaviour
{
    private Animator animator;
    SpriteRenderer sprite;
    Rigidbody2D rigi;
    int locker;
    //public GameObject particle;
    // public GameObject boomerang;


    // Start is called before the first frame update
    void Start()
    {

        animator = gameObject.GetComponent<Animator>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
        rigi = gameObject.GetComponent<Rigidbody2D>();


    }
    private void Awake()

    {

        spi = gameObject.GetComponent<SpriteRenderer>();

    }

    private SpriteRenderer spi;

    // Update is called once per frame 


    int speed = 5;
    //--- phan tinh diem
    public static int ABCD = 0;

    public GameObject fire;
    public GameObject fire2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
            sprite.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
            sprite.flipX = false;
        }

         //code nhay 
        if (Input.GetKey(KeyCode.Space )&& rigi.velocity.y < 0.01f)
        {
            rigi.AddForce(Vector3.up * 6f, ForceMode2D.Impulse);
        }


        // code nhay cao gap doi
        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    if (locker == 1)
        //    {
        //        rigi.AddForce(Vector3.up * 2, ForceMode2D.Impulse);
        //    }
        //    else
        //    {
        //        rigi.AddForce(Vector3.up * 3, ForceMode2D.Impulse);
        //    }
        //}

        //if (Input.GetKeyDown(KeyCode.O))
        //{
        //    if (locker == 1) locker = 0;
        //    else locker = 1;
        //}


        // code No Tung Nhan vat
        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    Instantiate(particle, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        //    Destroy(gameObject);
        //}


       if (Input.GetKeyDown(KeyCode.J))

        {

            
            
                if (spi.flipX == false)

                {

                    // Instantiate(fire, new Vector3(transform.position.x + 1f, transform.position.y + 2f, transform.position.z+5), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(fire, new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Instantiate(fire2, new Vector3(transform.position.x + 1f, transform.position.y , transform.position.z ), Quaternion.Euler(new Vector3(0, 0, 0)));
                }

                else if (spi.flipX == true)

                {
                    Instantiate(fire, new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z), Quaternion.Euler(new Vector3(0, 200, 0)));
                    Instantiate(fire2, new Vector3(transform.position.x - 1f, transform.position.y , transform.position.z ), Quaternion.Euler(new Vector3(0, 200, 0)));

                }
                animator.SetInteger("status", 2);
            

          

        }


        // code bam L xoay 90 do 
        //if (Input.GetKeyDown(KeyCode.L))
        //{
        //    transform.Rotate(Vector3.forward * -90);
        //}

        //if (Input.GetKeyUp(KeyCode.L))
        //{
        //    transform.Rotate(Vector3.forward * 90);
        //}



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Fruit"))
        {
            Destroy(collision.gameObject);
        }
    }
}

