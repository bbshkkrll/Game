using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertex : MonoBehaviour
{
    public static bool needRefreshPath = true;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Body"))
        {
            StartDijkstra.isTriggered[gameObject.name] = true;
            needRefreshPath = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Body"))
        {
            StartDijkstra.isTriggered[gameObject.name] = false;
            needRefreshPath = true;
        }
    }
    
}
