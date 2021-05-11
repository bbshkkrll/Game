using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabler : MonoBehaviour
{
    public GameObject birdFirst;
    public GameObject birdSecond;
    public GameObject bird3;
    [SerializeField]
    public float timer1 = 4f;
    [SerializeField]
    public float timer2 = 15f;

    public float timer3 = 10f;

    /*void Start()
    {
        birdFirst.SetActive(false);
        birdSecond.SetActive(false);
    }*/

    void Update()
    {
        timer1 -= Time.deltaTime;
        timer2 -= Time.deltaTime;
        timer3 -= Time.deltaTime;
        if (timer1 <= 0f) 
            birdFirst.SetActive(true);

        if (timer2 <= 0f) 
            birdSecond.SetActive(true);

        if (timer3 <= 0f)
            bird3.SetActive(true);
    }
    
}
