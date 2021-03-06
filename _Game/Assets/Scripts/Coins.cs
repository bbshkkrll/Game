using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static bool isCoinCollected = false;

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
            isCoinCollected = true;
            Destroy(gameObject);
        }
    }
}
