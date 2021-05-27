using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����� �����
/// </summary>
public class GraphEdge
{
    /// <summary>
    /// ��������� �������
    /// </summary>
    public GraphVertex ConnectedVertex { get; }

    /// <summary>
    /// ��� �����
    /// </summary>
    public int EdgeWeight { get; set; }

    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="connectedVertex">��������� �������</param>
    /// <param name="weight">��� �����</param>
    public GraphEdge(GraphVertex connectedVertex, int weight)
    {
        ConnectedVertex = connectedVertex;
        EdgeWeight = weight;
    }
}
/// <summary>
/// ����
/// </summary>
