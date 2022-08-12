using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOMERANG : MonoBehaviour
{
    // Start is called before the first frame update
    bool go;
    GameObject player;
    GameObject fire;
    Transform itemToRotate;
    Vector3 locationInFrontOfPlayer;
    void Start()
    {
        go = false;
        player = GameObject.Find("Player");
        fire = GameObject.Find("fire");
        fire.GetComponent<MeshRenderer>().enabled = false;
        itemToRotate = gameObject.transform.GetChild(0);
        locationInFrontOfPlayer = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z) + player.transform.forward * 10f;
        StartCoroutine(Boom());
    }
    IEnumerator Boom()
    {
        go = true;
        yield return new WaitForSeconds(1.5f);
        go = false;
    }

    // Update is called once per frame
    void Update()
    {
        itemToRotate.transform.Rotate(0, Time.deltaTime * 500, 0);
        if (go)
        {
            transform.position = Vector3.MoveTowards(transform.position, locationInFrontOfPlayer, Time.deltaTime * 40);
        }
        if (!go)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z),Time.deltaTime * 40);
        }
        if(!go && Vector3.Distance(player.transform.position,transform.position) < 1.5)
        {
            fire.GetComponent<MeshRenderer>().enabled = true;
            Destroy(this.gameObject);
        }

    }
}
