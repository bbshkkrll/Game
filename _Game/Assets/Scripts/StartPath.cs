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
    public void Start()
    {
        //new WaitForSeconds(2f);
        /*var pointStart = StartDijkstra.stringToObject["point10"];
        gameObject.transform.position = new Vector3(pointStart.transform.position.x, 
            pointStart.transform.position.y,
            pointStart.transform.position.z);*/
    }

    private void Update()
    {
        /*var path = StartDijkstra.dijkstra.FindShortestPath(StartDijkstra.parsedPath[count] + ' ', FindTrigger().name + ' ');
        StartDijkstra.parsedPath = path.Split(' ').ToList();
        StartDijkstra.parsedPath.RemoveAt(StartDijkstra.parsedPath.Count - 1);*/
        
        
        
        /*if (count < StartDijkstra.parsedPath.Count)
        { 
            nextPoint = StartDijkstra.stringToObject[StartDijkstra.parsedPath[count]];
            var nextTransform = StartDijkstra.stringToObject[StartDijkstra.parsedPath[count]].transform;
            transform.position = Vector3.MoveTowards(transform.position, nextTransform.position, speed * Time.deltaTime);
            if (transform.position == nextTransform.position)
                count++;
        }*/
        /*var path = StartDijkstra.dijkstra.FindShortestPath("point0 ", FindTrigger().name + " ");
        var partsOfPath = path.Split(' ').ToList();
        partsOfPath.RemoveAt(path.Length - 1);*/
        if (Vertex.needRefreshPath && isReached)
        {
            nextPoint = FindTrigger();
            var path = StartDijkstra.dijkstra.FindShortestPath(previousPoint.name + ' ', nextPoint.name + ' ').Split(' ').ToList();
            path.RemoveAt(path.Count - 1);
            StartDijkstra.parsedPath.AddRange(path);
            isReached = false;
        }
        if (count < StartDijkstra.parsedPath.Count)
        {
            previousPoint = StartDijkstra.stringToObject[StartDijkstra.parsedPath[count]];
            //var nextTransform = StartDijkstra.stringToObject[StartDijkstra.parsedPath[count]].transform;
            var nextTransform = previousPoint.transform;
            transform.position = Vector3.MoveTowards(transform.position, nextTransform.position, speed * Time.deltaTime);
            if (transform.position == nextTransform.position)
                count++;
            if (transform.position == nextPoint.transform.position)
            {
                isReached = true;
            }
            /*if (Vertex.needRefreshPath)
                count = 0;*/
        }
    }

    public static GameObject FindTrigger()
    {
        var defaultPosition = StartDijkstra.stringToObject["point5"];
        foreach (var trigger in StartDijkstra.isTriggered.Values)
        {
            if (trigger)
            {
                var triggeredPoint = StartDijkstra.isTriggered.First(x => x.Value).Key;
                //Debug.Log(StartDijkstra.stringToObject[triggeredPoint].name);
                return StartDijkstra.stringToObject[triggeredPoint];
            }
        }

        return defaultPosition;
    }

    public static void MoveToNextPoint(List<string> path, int count)
    {
        
    }
    
}
