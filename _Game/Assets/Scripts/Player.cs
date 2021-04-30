using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealt = 3;
    public int currentHealth;
    public HealthBar healthBar;
        
        
    public float speed = 5f;

    private void Start()
    {
        currentHealth = maxHealt;
    }

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
            TakeDamage(1);
            Destroy(collision2D.gameObject);
        }
    }

    void TakeDamage(int dmg)
    {
        healthBar.SetHealth(currentHealth);
        
        currentHealth -= dmg;
    }
    /*private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Balloon"))
        {
            Destroy(gameObject);
        }
    }*/
}
