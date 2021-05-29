using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y > 8f)
            Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            if (!gameObject.CompareTag(("YellowBalloon")))
            {
                BalloonsText.Balloon++;
                Destroy(gameObject);
            }
            else
            {
                BalloonsText.Balloon += 3;
                Destroy(gameObject);
            }
    }
}