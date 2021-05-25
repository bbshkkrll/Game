using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���������� � �������
/// </summary>
public class GraphVertexInfo : MonoBehaviour
{
    /// <summary>
    /// �������
    /// </summary>
    public GraphVertex Vertex { get; set; }

    /// <summary>
    /// �� ���������� �������
    /// </summary>
    public bool IsUnvisited { get; set; }

    /// <summary>
    /// ����� ����� �����
    /// </summary>
    public int EdgesWeightSum { get; set; }

    /// <summary>
    /// ���������� �������
    /// </summary>
    public GraphVertex PreviousVertex { get; set; }

    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="vertex">�������</param>
    public GraphVertexInfo(GraphVertex vertex)
    {
        Vertex = vertex;
        IsUnvisited = true;
        EdgesWeightSum = int.MaxValue;
        PreviousVertex = null;
    }
}
