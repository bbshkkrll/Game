using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{       
    public int maxHealt = 100;
    public float currentHealth;
    public HealthBar healthBar;
    private bool trigger;

    public GameManagger eventManager;

    public static bool isPlayerAlive = true;
        
    public float speed = 5f;

    private void Start()
    {
        currentHealth = maxHealt;
    }

    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        var dir = new Vector3(horizontal, vertical, 0);
        transform.Translate(dir.normalized * (Time.deltaTime * speed));
        
    }

    private void FixedUpdate()
    {
        if (trigger && !Shield.isShieldActieve)
        {
            TakeDamage(50);
        }
    }
    
    private void TakeDamage(float dmg)
    {
        healthBar.SetHealth(currentHealth);

        currentHealth -= dmg * Time.deltaTime;
        if (currentHealth < 0)
        {
            isPlayerAlive = false;
            currentHealth = 0;
            eventManager.EndGame();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bird") && !Shield.isShieldActieve)
        {
            Debug.Log("asd");
            trigger = true;
             TakeDamage(50);
            //?? ????? ????? ???????))0)
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Bird") && !Shield.isShieldActieve)
        {
            trigger = false;
        }
    }
}
