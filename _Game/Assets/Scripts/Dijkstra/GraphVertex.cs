using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������� �����
/// </summary>
public class GraphVertex : MonoBehaviour
{
    /// <summary>
    /// �������� �������
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// ������ �����
    /// </summary>
    public List<GraphEdge> Edges { get; }

    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="vertexName">�������� �������</param>
    public GraphVertex(string vertexName)
    {
        Name = vertexName;
        Edges = new List<GraphEdge>();
    }

    /// <summary>
    /// �������� �����
    /// </summary>
    /// <param name="newEdge">�����</param>
    public void AddEdge(GraphEdge newEdge)
    {
        Edges.Add(newEdge);
    }

    /// <summary>
    /// �������� �����
    /// </summary>
    /// <param name="vertex">�������</param>
    /// <param name="edgeWeight">���</param>
    public void AddEdge(GraphVertex vertex, int edgeWeight)
    {
        AddEdge(new GraphEdge(vertex, edgeWeight));
    }

    /// <summary>
    /// �������������� � ������
    /// </summary>
    /// <returns>��� �������</returns>
    public override string ToString() => Name;
}
