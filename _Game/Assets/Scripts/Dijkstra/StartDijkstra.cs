using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Pathfinding;
using UnityEngine;

public class StartDijkstra : MonoBehaviour
{
    public  List<GameObject> points;
    public static Dictionary<GameObject, string> objectToString;
    public static Dictionary<string, GameObject> stringToObject;
    //добавить словарь вершин и поинтов
    private static List<string> vertexes;

    public static Dictionary<string, bool> isTriggered;
    
    //private static List<Transform> transforms;

    public static Graph graph;
    public static string path;
    public static List<string> parsedPath;
    public static Dijkstra dijkstra;


    public static List<string> path2;


    private void Start()
    {
        graph = new Graph();
        //points = new List<GameObject>();
        isTriggered = new Dictionary<string, bool>();
        objectToString = new Dictionary<GameObject, string>();
        stringToObject = new Dictionary<string, GameObject>();
        vertexes = new List<string>();

        for (var i = 0; i < points.Count; i++)
        {
            isTriggered.Add("point" + i, false);
            objectToString.Add(points[i], "point" + i);
            stringToObject.Add("point" + i, points[i]);
            vertexes.Add("point" + i + " ");
            graph.AddVertex("point" + i + " ");
        }
        graph.AddEdge("point0 ", "point1 ", 1);
        graph.AddEdge("point1 ", "point2 ", 1);
        graph.AddEdge("point1 ", "point6 ", 1);
        graph.AddEdge("point2 ", "point7 ", 1);
        graph.AddEdge("point2 ", "point3 ", 1);
        graph.AddEdge("point3 ", "point8 ", 1);
        graph.AddEdge("point3 ", "point4 ", 1);
        graph.AddEdge("point4 ", "point5 ", 1);
        graph.AddEdge("point4 ", "point9 ", 1);
        graph.AddEdge("point5 ", "point10 ", 1);
        graph.AddEdge("point10 ", "point9 ", 1);
        graph.AddEdge("point9 ", "point8 ", 1);
        graph.AddEdge("point8 ", "point7 ", 1);
        graph.AddEdge("point7 ", "point6 ", 1);
        graph.AddEdge("point6 ", "point11 ", 1);
        graph.AddEdge("point7 ", "point6 ", 1);
        graph.AddEdge("point11 ", "point12 ", 1);
        graph.AddEdge("point7 ", "point12 ", 1);
        graph.AddEdge("point12 ", "point13 ", 1);
        graph.AddEdge("point8 ", "point13 ", 1);
        graph.AddEdge("point13 ", "point14 ", 1);
        graph.AddEdge("point9 ", "point14 ", 1);
        graph.AddEdge("point10 ", "point15 ", 1);
        graph.AddEdge("point14 ", "point15 ", 1);



        dijkstra = new Dijkstra(graph); 
        path = dijkstra.FindShortestPath("point2 ", "point2 ");
        parsedPath = path.Split(' ').ToList();
        parsedPath.RemoveAt(parsedPath.Count - 1);
        Debug.Log(path);
        foreach (var e in parsedPath) Debug.Log(e);
    }
    
}
