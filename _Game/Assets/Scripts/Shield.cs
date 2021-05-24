using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject circle;
    public int count = 20;
    public static float time = 5f;
    
    public static bool isShieldActieve = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && count <= BalloonsText.Balloon)
        {

            isShieldActieve = true;
            circle.SetActive(true);
            BalloonsText.Balloon -= count;
            time = 5f;
        }

        if (circle.activeSelf && time >= 0.01f)
            time -= Time.deltaTime;
        else
        {
            circle.SetActive(false);
            isShieldActieve = false;
        }
        
    }

/*    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            Destroy(other);
        }
    }*/
}
