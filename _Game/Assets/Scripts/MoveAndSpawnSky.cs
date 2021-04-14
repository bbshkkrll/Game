using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndSpawnSky : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject sky;
    private void Update()
    {
        transform.Translate(Vector3.up * (speed * Time.deltaTime));
        
        if (transform.position.y > 10.07f)
        {
            Instantiate(sky, new Vector3(0, -10.14f, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
