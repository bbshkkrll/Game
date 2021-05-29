using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Pathfinding;
using UnityEngine;

public class StartDijkstra : MonoBehaviour
{
    public List<GameObject> points;
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

        foreach (var point in points)
        {
            Debug.Log(point.name);
            isTriggered.Add(point.name, false);
            objectToString.Add(point, point.name);
            stringToObject.Add(point.name, point);
            vertexes.Add(point.name + " ");
            graph.AddVertex(point.name + " ");
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
        graph.AddEdge("point11 ", "point16 ", 1);
        graph.AddEdge("point16 ", "point17 ", 1);
        graph.AddEdge("point12 ", "point17 ", 1);
        graph.AddEdge("point13 ", "point18 ", 1);
        graph.AddEdge("point17 ", "point18 ", 1);
        graph.AddEdge("point18 ", "point19 ", 1);
        graph.AddEdge("point14 ", "point19 ", 1);
        graph.AddEdge("point19 ", "point20 ", 1);
        graph.AddEdge("point15 ", "point20 ", 1);
        graph.AddEdge("point16 ", "point21 ", 1);
        graph.AddEdge("point21 ", "point22 ", 1);
        graph.AddEdge("point17 ", "point22 ", 1);
        graph.AddEdge("point22 ", "point23 ", 1);
        graph.AddEdge("point18 ", "point23 ", 1);
        graph.AddEdge("point23 ", "point24 ", 1);
        graph.AddEdge("point19 ", "point24 ", 1);
        graph.AddEdge("point24 ", "point25 ", 1);
        graph.AddEdge("point20 ", "point25 ", 1);
        graph.AddEdge("point21 ", "point26 ", 1);
        graph.AddEdge("point26 ", "point27 ", 1);
        graph.AddEdge("point14 ", "point15 ", 1);
        graph.AddEdge("point22 ", "point27 ", 1);
        graph.AddEdge("point27 ", "point28 ", 1);
        graph.AddEdge("point23 ", "point28 ", 1);
        graph.AddEdge("point14 ", "point15 ", 1);
        graph.AddEdge("point28 ", "point29 ", 1);
        graph.AddEdge("point24 ", "point29 ", 1);
        graph.AddEdge("point29 ", "point30 ", 1);
        graph.AddEdge("point25 ", "point30 ", 1);
        graph.AddEdge("point36 ", "point37 ", 1);
        graph.AddEdge("point37 ", "point38 ", 1);
        graph.AddEdge("point38 ", "point39 ", 1);
        graph.AddEdge("point39 ", "point40 ", 1);
        graph.AddEdge("point41 ", "point42 ", 1);
        graph.AddEdge("point42 ", "point43 ", 1);
        graph.AddEdge("point43 ", "point44 ", 1);
        graph.AddEdge("point44 ", "point45 ", 1);
        graph.AddEdge("point36 ", "point41 ", 1);
        graph.AddEdge("point37 ", "point42 ", 1);
        graph.AddEdge("point38 ", "point43 ", 1);
        graph.AddEdge("point39 ", "point44 ", 1);
        graph.AddEdge("point40 ", "point45 ", 1);
        graph.AddEdge("point31 ", "point32 ", 1);
        graph.AddEdge("point32 ", "point33 ", 1);
        graph.AddEdge("point33 ", "point34 ", 1);
        graph.AddEdge("point34 ", "point35 ", 1);
        graph.AddEdge("point26 ", "point31 ", 1);
        graph.AddEdge("point27 ", "point32 ", 1);
        graph.AddEdge("point28 ", "point33 ", 1);
        graph.AddEdge("point29 ", "point34 ", 1);
        graph.AddEdge("point30 ", "point35 ", 1);



        dijkstra = new Dijkstra(graph); 
        path = dijkstra.FindShortestPath("point5 ", "point5 ");
        parsedPath = path.Split(' ').ToList();
        parsedPath.RemoveAt(parsedPath.Count - 1);
        Debug.Log(path);
        foreach (var e in parsedPath) Debug.Log(e);
    }
    
}
