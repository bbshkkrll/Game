using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class StartPath : MonoBehaviour
{
    public float speed = 2f;
    private int count = 0;

    public GameObject nextPoint;

    public GameObject previousPoint;
    private Transform target;

    private static bool isReached = false;
    private static bool isReachedCurrent = false;
    

    private void Update()
    {
        if (Vertex.needRefreshPath && isReached)
        {
            
            nextPoint = FindTrigger();
            var path = StartDijkstra.dijkstra.FindShortestPath(previousPoint.name + ' ', nextPoint.name + ' ').Split(' ').ToList();
            path.RemoveAt(path.Count - 1);
            //StartDijkstra.parsedPath.RemoveRange(0,StartDijkstra.parsedPath.Count);
            StartDijkstra.parsedPath.RemoveRange(0, count);
            StartDijkstra.parsedPath.AddRange(path);
            isReached = false;
            count = 0;
        }
        if (count < StartDijkstra.parsedPath.Count)
        {
            Debug.Log("count: " + count);
            previousPoint = StartDijkstra.stringToObject[StartDijkstra.parsedPath[count]];
            //var nextTransform = StartDijkstra.stringToObject[StartDijkstra.parsedPath[count]].transform;
            var nextTransform = previousPoint.transform;
            transform.position = Vector3.MoveTowards(transform.position, nextTransform.position, speed * Time.deltaTime);
            if (transform.position == nextTransform.position)
                count++;
            if (transform.position == nextPoint.transform.position)
            {
                isReached = true;
                //count = 0;
            }
        }
        /*if (Vertex.needRefreshPath && isReached)
        {
            nextPoint = FindTrigger();
            var path = StartDijkstra.dijkstra.FindShortestPath(previousPoint.name + ' ', nextPoint.name + ' ').Split(' ').ToList();
            path.RemoveAt(path.Count - 1);
            //StartDijkstra.parsedPath.RemoveRange(0,StartDijkstra.parsedPath.Count);
            
            //StartDijkstra.parsedPath.AddRange(path);
            foreach (var point in path)
            {
                Debug.Log(point + " Dequeue");
                StartDijkstra.queuePath.Enqueue(point);
            }
            isReached = false;
            
        }
        
        if (StartDijkstra.queuePath.Count != 0 && !isReachedCurrent)
        {
            Debug.Log("NEN");
            previousPoint = StartDijkstra.stringToObject[StartDijkstra.queuePath.Dequeue()];
            var nextTransform = previousPoint.transform;
            transform.position = Vector3.MoveTowards(transform.position,
                nextTransform.position, speed * Time.deltaTime);

            isReachedCurrent = false;
            
            if (transform.position == nextTransform.position)
                isReachedCurrent = true;
            
            if (transform.position == nextPoint.transform.position)
            {
                isReached = true;
                StartDijkstra.queuePath.Clear();
            }
        }*/
    }

    public static GameObject FindTrigger()
    {
        var defaultPosition = StartDijkstra.stringToObject["point5"];
        if (StartDijkstra.isTriggered.Values.Any(trigger => trigger))
        {
            var triggeredPoint = StartDijkstra.isTriggered.First(x => x.Value).Key;
            return StartDijkstra.stringToObject[triggeredPoint];
        }

        return defaultPosition;
    }
}
