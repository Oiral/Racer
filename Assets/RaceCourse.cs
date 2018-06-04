using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceCourse : MonoBehaviour {

    public Color lineColor;
    public Color nodeColor;
    List<Transform> nodes = new List<Transform>();

    private void OnDrawGizmos()
    {
        

        Transform[] pathTransfrom = GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransfrom.Length; i++)
        {
            if (pathTransfrom[i] != transform)
            {
                nodes.Add(pathTransfrom[i]);
            }
        }
        

        for (int i = 0; i < nodes.Count; i++)
        {
            Vector3 currentNode = nodes[i].position;

            Vector3 previousNode = Vector3.zero;
            if (i > 0)
            {
                previousNode = nodes[i - 1].position;
            } else if (i == 0 && nodes.Count > 1)
            {
                previousNode = nodes[nodes.Count - 1].position;
            }
            Gizmos.color = lineColor;
            Gizmos.DrawLine(currentNode, previousNode);
            Gizmos.color = nodeColor;
            Gizmos.DrawSphere(currentNode, 1);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Transform[] pathTransfrom = GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransfrom.Length; i++)
        {
            if (pathTransfrom[i] != transform)
            {
                nodes.Add(pathTransfrom[i]);
                pathTransfrom[i].name = "node (" + (i-1).ToString() + ")";
            }
        }
    }

}
