using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y > 8f)
            Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            MoneyText.Coin++;
            Destroy(gameObject);
        }
    }
}