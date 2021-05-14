using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    private float attackRate = 1f;
    private float nextAttackTime = 0f;




    public float speed = 5f;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        var dir = new Vector3(horizontal, vertical, 0);
        transform.Translate(dir.normalized * (Time.deltaTime * speed));
        
    }

    private void OnCollisionStay2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Bird") && Time.time >= nextAttackTime)
        {
            TakeDamage();
            nextAttackTime = Time.time + 1f / attackRate;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bird"))
            TakeDamage();
    }

    void TakeDamage()
    {
        healthBar.SetHealth(currentHealth);
        currentHealth --;
    }



    /*private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Balloon"))
        {
            Destroy(gameObject);
        }
    }*/
}
