using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fire_control2 : MonoBehaviour
{

    // Start is called before the first frame update 

    int speed = 10;

    public bool isRight = true;

    public GameObject fire;

    SpriteRenderer sprite;

    Vector3 vector;

    public GameObject soundfire;
    public AudioSource fireAudio;

    void Start()

    {

        // if (gameObject != null) 

        //{ 

        //  Destroy(this.gameObject, 2); 

        //} 

        Destroy(gameObject, 2);

        sprite = gameObject.GetComponent<SpriteRenderer>();
        fireAudio = gameObject.GetComponent<AudioSource>();
        sprite.flipX = !isRight;

        if (isRight)

        {

            vector = new Vector3(-1, 0, 0);

        }

        else

        {

            vector = new Vector3(1, 0, 0);

        }

    }



    // Update is called once per frame 

    void Update()

    {
        transform.Translate(vector * speed * Time.deltaTime);

        // code ban thang len troi 
        //transform.Translate(Vector3.up * speed * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D collision)

    {

        Debug.Log("va cham" + collision.gameObject.name);

        if (collision.gameObject.tag.Equals("enermy"))

        {

            fireAudio.Play();

            // phần làm thêm của bài 6 (UI) 

            Text ABCD = GameObject.Find("SCORE").GetComponent<Text>();

            RAMBO_SCRIPT.ABCD++;

            ABCD.text = "SCORE : " + RAMBO_SCRIPT.ABCD;

            // -------  



            Destroy(collision.gameObject);

            Destroy(gameObject);

            Instantiate(fire, collision.gameObject.transform.position, Quaternion.identity);

        }

    }

}
