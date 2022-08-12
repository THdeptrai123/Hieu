using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enermy_fire : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 target;
    public float moveSpeed = 5;
    public GameObject fire;
    void Start()
    {

        if (gameObject != null)
        {
            Destroy(this.gameObject, 0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((transform.position - target) * moveSpeed * Time.deltaTime * - 1);
    }
    void OnCollisionEnter2D(Collision2D collision)

    {

        Debug.Log("va cham" + collision.gameObject.name);

        if (collision.gameObject.tag.Equals("Player"))

        {

          //  Destroy(collision.gameObject);

           Destroy(gameObject);

            Instantiate(fire, collision.gameObject.transform.position, Quaternion.identity);
            SceneManager.LoadScene("gameover", LoadSceneMode.Single);
        }

    }
}
