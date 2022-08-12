using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thanhmauNhanvat : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxheal;
    float currentheal;
    public GameObject bloodeffect;

    public Slider PlayerhealSlider;
    void Start()
    {
        currentheal = maxheal;
        PlayerhealSlider.maxValue = maxheal;
        PlayerhealSlider.value = maxheal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void adddame(float dame)
    {
        if (dame < 0)
            return;
        currentheal -= dame;
        PlayerhealSlider.value = currentheal;
        if (currentheal <= 0)
            makedead();

        
    }
    void makedead()
    {
        Instantiate(bloodeffect, transform.position, transform.rotation);
    }
}
