using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public static Dictionary<string, bool> PointsTrigger;
    //public static List<Tuple<string, bool>> PointsTrigger; // здесь без пробела points1
    public GameObject pointStart;
    public List<GameObject> Points;
    public BoxCollider2D Collider;

    public void Start()
    {
        Collider = GetComponent(BoxCollider2D);
        PointsTrigger = new Dictionary<string, bool>();
        foreach (var point in Points)
            PointsTrigger.Add(point.name, false);

        /*gameObject.transform.position = new Vector3(pointStart.transform.position.x,
           pointStart.transform.position.y,
           pointStart.transform.position.z);*/
    }

    void Update()
    {
        transform.Translate(Vector2.up * (0.1f * Time.deltaTime));
        foreach (var e in PointsTrigger)
            if(e.Value)
            {
                StartDijkstra.graph.FindVertex(e.Key + ' ').Edges.ForEach(x => x.EdgeWeight += 50);
                PointsTrigger[e.Key] = false;
            }

    }



}
