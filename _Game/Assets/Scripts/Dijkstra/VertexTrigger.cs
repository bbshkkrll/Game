using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexTrigger : MonoBehaviour
{
    public static bool needUpdateEdges = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wind"))
        {
            Wind.PointsTrigger[gameObject.name] = true;
            //needUpdateEdges = true;
            Debug.Log("Wind");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wind"))
        {
            Debug.Log("Wind out");
            Wind.PointsTrigger[gameObject.name] = false;
            StartDijkstra.graph.FindVertex(gameObject.name + ' ').Edges.ForEach(x => x.EdgeWeight -= 50);
        }
    }
}