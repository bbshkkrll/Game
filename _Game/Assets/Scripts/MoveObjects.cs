using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MoveObjects : MonoBehaviour
{
    private Random rnd = new Random();
    public GameObject redBalloon;
    private float nextFloat;
    public float speed = 2f;
    private void Start()
    {
        nextFloat = rnd.Next(-10,10);
    }

    public void FixedUpdate()
    {
        transform.Translate(Vector3.up * (speed * Time.deltaTime));

        if (transform.position.y > 7.5f)
        {
            Instantiate(redBalloon, new Vector3(nextFloat, -7.5f, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
