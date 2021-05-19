using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagger gameManager;

    public static bool isContacted = false;
    public static float time = 3.5f;

    void Update()
    {
        if (isContacted && time > 0)
            time -= Time.deltaTime;
        if (time <= 0)
            gameManager.CompleteLevel();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            isContacted = true;
    }
}