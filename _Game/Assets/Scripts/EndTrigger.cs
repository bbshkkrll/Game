using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagger gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        gameManager.CompleteLevel();
        Debug.Log("WIN!");
    }
}