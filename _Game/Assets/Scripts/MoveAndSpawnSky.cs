using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndSpawnSky : MonoBehaviour
{
    public float speed = 1.5f;
    public GameObject sky;
    public GameObject finishSky;
    public int finishCount = 5;
    public int finishSkyCount = 0;
    private void Update()
    {
        transform.Translate(Vector3.up * (speed * Time.deltaTime));
        
        if (MoneyText.Coin < finishCount)
        {

            if (transform.position.y > 9.93f)
            {
                Instantiate(sky, new Vector3(0, -9.98f, 0), Quaternion.identity);
                Destroy(gameObject);
            }
        }
        else
        {
            if (transform.position.y > 9.93f && finishSkyCount < 2)
            {
                finishSkyCount++;
                Instantiate(sky, new Vector3(0, -9.98f, 0), Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
