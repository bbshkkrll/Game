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

            if (other.gameObject.CompareTag("Wind"))
            {
                Wind.PointsTrigger[gameObject.name] = true;
                //needUpdateEdges = true;
                Debug.Log("Wind");
            }
            if (other.gameObject.CompareTag("Body"))
            {
                StartDijkstra.isTriggered[gameObject.name] = true;
                needRefreshPath = true;
                Debug.Log("Body");

            }

    }
/*    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wind"))
        {
            Wind.PointsTrigger[gameObject.name] = true;
            //needUpdateEdges = true;
            Debug.Log("Wind");
        }
    }*/

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wind"))
        {
            Wind.PointsTrigger[gameObject.name] = false;
            StartDijkstra.graph.FindVertex(gameObject.name + ' ').Edges.ForEach(x => x.EdgeWeight -= 50);
        }
        if (other.gameObject.CompareTag("Body"))
        {
            StartDijkstra.isTriggered[gameObject.name] = false;
            needRefreshPath = false;
        } 

    }

}