using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MoveSky : MonoBehaviour
{
    public GameObject sky;
    public GameObject finishSky;
    public int finishCount = 2;
    public float speed = 2f;

    private static bool isFinishNotSpawned = true;

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
                /*if (transform.position.y >= 15.9f)
                    Destroy(gameObject);*/
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