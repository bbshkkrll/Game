using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StartPath : MonoBehaviour
{
    public float speed = 2f;
    private int count = 1;

    public static GameObject nextPoint;

    public Transform target;
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
        var path = StartDijkstra.dijkstra.FindShortestPath(StartDijkstra.parsedPath[count] + ' ', FindTrigger().name + ' ');
        StartDijkstra.parsedPath = path.Split(' ').ToList();
        StartDijkstra.parsedPath.RemoveAt(StartDijkstra.parsedPath.Count - 1);
        
        
        
        if (count < StartDijkstra.parsedPath.Count)
        { 
            nextPoint = StartDijkstra.stringToObject[StartDijkstra.parsedPath[count]];
            var nextTransform = StartDijkstra.stringToObject[StartDijkstra.parsedPath[count]].transform;
            transform.position = Vector3.MoveTowards(transform.position, nextTransform.position, speed * Time.deltaTime);
            if (transform.position == nextTransform.position)
                count++;
        }
    }

    public static GameObject FindTrigger()
    {
        var defaultPosition = StartDijkstra.stringToObject["point5"];
        if (StartDijkstra.isTriggered.Values.Any(trigger => trigger))
        {
            var triggeredPoint = StartDijkstra.isTriggered.First(x => x.Value).Key;
            //Debug.Log(StartDijkstra.stringToObject[triggeredPoint].name);
            return StartDijkstra.stringToObject[triggeredPoint];
        }

        return defaultPosition;
    }
    
}
