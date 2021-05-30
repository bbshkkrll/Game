using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MoveSky : MonoBehaviour
{
    public GameObject sky;
    public GameObject finishSky;
    public static int finishCount = 25;
    public float speed = 2f;

    public static bool isFinishNotSpawned = true;

    private bool isSpanw = true;

    public void FixedUpdate()
    {
        transform.Translate(Vector3.up * (speed * Time.deltaTime));
     
        if (MoneyText.Coin < finishCount)
        {
            if (transform.position.y >= 0.0239f && isSpanw)
            {
                isSpanw = false;
                Instantiate(sky, new Vector2(0, -9.98f), Quaternion.identity);
            }
        }
        else
        {
            if (transform.position.y >= 0.0239f && isFinishNotSpawned)
            {
                Instantiate(finishSky, new Vector2(0, -9.98f), Quaternion.identity);
                isFinishNotSpawned = false;
            }
        }
    }
}