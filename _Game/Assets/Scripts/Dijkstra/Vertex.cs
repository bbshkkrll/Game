using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertex : MonoBehaviour
{
    public static bool needRefreshPath = false;
    public static bool needUpdateEdges = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Body"))
        {
            StartDijkstra.isTriggered[gameObject.name] = true;
            needRefreshPath = true;
            Debug.Log("Body");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Body"))
        {
            StartDijkstra.isTriggered[gameObject.name] = false;
            needRefreshPath = false;
        }
    }
}