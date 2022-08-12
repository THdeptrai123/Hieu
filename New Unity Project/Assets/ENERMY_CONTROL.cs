using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENERMY_CONTROL : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Boom;
    public float minBomtime = 2;
    public float maxBomtime = 4;
    private float boomTime = 0;
    private float lastBomtime = 0;
    private GameObject player;
    void Start()
    {
        //updateBomtime();
        player = GameObject.FindGameObjectWithTag("cloudy");

    }

    // Update is called once per frame
    int count = 150, a = 1, direction = 0;

    void Update()
    {
        if (Time.time >= lastBomtime + boomTime)
        {
            throughBom();
         
           
        }

        //code di chuyen AI
        //{
        //    Vector3 characterScale = transform.localScale;

        //    if (count == 150)
        //    {
        //        a = 1;
        //    }
        //    else if (count == -150)
        //    {
        //        a = 0;
        //    }

        //    if (a == 1)
        //    {
        //        count--;
        //    }
        //    else count++;

        //    if (count > 10)
        //    {
        //        transform.Translate(Vector3.right * 4 * Time.deltaTime);
        //        characterScale.x = 3;
        //        transform.localScale = characterScale;
        //    }
        //    else if (count < -10)
        //    {
        //        transform.Translate(Vector3.left * 4 * Time.deltaTime);
        //        characterScale.x = -3;
        //        transform.localScale = characterScale;
        //    }
        //}
    }
    void updateBomtime()
    {
        lastBomtime = Time.time;
        boomTime = Random.Range(minBomtime, maxBomtime + 1);
        

    }
    void throughBom()
    {
        GameObject bom = Instantiate(Boom, transform.position, Quaternion.identity) as GameObject;
        
        bom.GetComponent<Enermy_fire>().target = player.transform.position;
        updateBomtime();
    }

}
