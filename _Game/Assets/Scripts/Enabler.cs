using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabler : MonoBehaviour
{
    public GameObject birdFirst;
    public GameObject birdSecond;
    [SerializeField]
    public float timeSleep = 4f;
    [SerializeField]
    public float sleepTimer = 15f;

    void Start()
    {
        birdFirst.SetActive(false);
        birdSecond.SetActive(false);
    }

    void Update()
    {
        timeSleep -= Time.deltaTime;
        sleepTimer -= Time.deltaTime;
        if (timeSleep <= 0f)
        {
            birdFirst.SetActive(true);
        }

        if (sleepTimer <= 0f)
        {
            birdSecond.SetActive(true);
        }
    }
}
