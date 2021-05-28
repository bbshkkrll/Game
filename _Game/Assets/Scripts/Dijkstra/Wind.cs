using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public static Dictionary<string, bool> PointsTrigger;
    //public static List<Tuple<string, bool>> PointsTrigger; // ����� ��� ������� points1
    public GameObject pointStart;
    public List<GameObject> Points;

    public void Start()
    {
        PointsTrigger = new Dictionary<string, bool>();
       /* for (var i = 0; i < Points.Count; i++)
        {
            PointsTrigger.Add("point" + i, false);
            Debug.Log(i);
        }*/
        foreach(var point in Points)
        {
            PointsTrigger.Add(point.name, false);
        }

        /*gameObject.transform.position = new Vector3(pointStart.transform.position.x,
           pointStart.transform.position.y,
           pointStart.transform.position.z);*/
    }

    void Update()
    {
        var needRefresh = new List<string>();
        transform.Translate(Vector2.up * (0.1f * Time.deltaTime));
        foreach (var e in PointsTrigger)
        {
            if (e.Value)
            {
                StartDijkstra.graph.FindVertex(e.Key + ' ').Edges.ForEach(x => x.EdgeWeight += 50);
                Debug.Log("Зашел");
                needRefresh.Add(e.Key);
            }
        }

        foreach (var flag in needRefresh)
        {
            PointsTrigger[flag] = false;
        }
    }



}
