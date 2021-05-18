using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MoveObjects : MonoBehaviour
{
    public float speed = 2f;
    public void FixedUpdate()
    {
        transform.Translate(Vector3.up * (speed * Time.deltaTime));

        /*if (transform.position.y > 10.53f && gameObject.tag != ("undeleted"))
        {
            Destroy(gameObject);
        }*/
    }
}
