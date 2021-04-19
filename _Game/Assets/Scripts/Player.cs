using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(horizontal, vertical, 0);
        transform.Translate(dir.normalized * (Time.deltaTime * speed));
    }

    private void OnCollisionStay2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Balloon"))
        {
            Destroy(gameObject);
        }
    }

    /*private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Balloon"))
        {
            Destroy(gameObject);
        }
    }*/
}
