using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������� ��������
/// </summary>
public class Dijkstra
{
    public Graph graph;

    List<GraphVertexInfo> infos;

    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="graph">����</param>
    public Dijkstra(Graph graph)
    {
        this.graph = graph;
    }

    /// <summary>
    /// ������������� ����������
    /// </summary>
    void InitInfo()
    {
        infos = new List<GraphVertexInfo>();
        foreach (var v in graph.Vertices)
            infos.Add(new GraphVertexInfo(v));
    }

    /// <summary>
    /// ��������� ���������� � ������� �����
    /// </summary>
    /// <param name="v">�������</param>
    /// <returns>���������� � �������</returns>
    GraphVertexInfo GetVertexInfo(GraphVertex v)
    {
        foreach (var i in infos)
            if (i.Vertex.Equals(v))
                return i;

        return null;
    }

    /// <summary>
    /// ����� ������������ ������� � ����������� ��������� �����
    /// </summary>
    /// <returns>���������� � �������</returns>
    public GraphVertexInfo FindUnvisitedVertexWithMinSum()
    {
        var minValue = int.MaxValue;
        GraphVertexInfo minVertexInfo = null;
        foreach (var i in infos)
            if (i.IsUnvisited && i.EdgesWeightSum < minValue)
            {
                minVertexInfo = i;
                minValue = i.EdgesWeightSum;
            }

        return minVertexInfo;
    }

    /// <summary>
    /// ����� ����������� ���� �� ��������� ������
    /// </summary>
    /// <param name="startName">�������� ��������� �������</param>
    /// <param name="finishName">�������� �������� �������</param>
    /// <returns>���������� ����</returns>
    public string FindShortestPath(string startName, string finishName)
    {
        return FindShortestPath(graph.FindVertex(startName), graph.FindVertex(finishName));
    }

    /// <summary>
    /// ����� ����������� ���� �� ��������
    /// </summary>
    /// <param name="startVertex">��������� �������</param>
    /// <param name="finishVertex">�������� �������</param>
    /// <returns>���������� ����</returns>
    public string FindShortestPath(GraphVertex startVertex, GraphVertex finishVertex)
    {
        InitInfo();
        var first = GetVertexInfo(startVertex);
        first.EdgesWeightSum = 0;
        while (true)
        {
            var current = FindUnvisitedVertexWithMinSum();
            if (current == null)
                break;

            SetSumToNextVertex(current);
        }

        return GetPath(startVertex, finishVertex);
    }

    /// <summary>
    /// ���������� ����� ����� ����� ��� ��������� �������
    /// </summary>
    /// <param name="info">���������� � ������� �������</param>
    void SetSumToNextVertex(GraphVertexInfo info)
    {
        info.IsUnvisited = false;
        foreach (var e in info.Vertex.Edges)
        {
            var nextInfo = GetVertexInfo(e.ConnectedVertex);
            var sum = info.EdgesWeightSum + e.EdgeWeight;
            if (sum < nextInfo.EdgesWeightSum)
            {
                nextInfo.EdgesWeightSum = sum;
                nextInfo.PreviousVertex = info.Vertex;
            }
        }
    }

    /// <summary>
    /// ������������ ����
    /// </summary>
    /// <param name="startVertex">��������� �������</param>
    /// <param name="endVertex">�������� �������</param>
    /// <returns>����</returns>
    string GetPath(GraphVertex startVertex, GraphVertex endVertex)
    {
        var path = endVertex.ToString();
        while (startVertex != endVertex)
        {
            endVertex = GetVertexInfo(endVertex).PreviousVertex;
            path = endVertex.ToString() + path;
        }

        return path;
    }
}