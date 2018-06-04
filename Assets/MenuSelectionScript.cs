using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelectionScript : MonoBehaviour {

    public Color baseColor = Color.blue;
    public Color lineColor = Color.black;
    List<Transform> posNodes = new List<Transform>();

    private void OnDrawGizmos()
    {
        Transform[] postitionsTransforms = GetComponentsInChildren<Transform>();
        posNodes = new List<Transform>();

        for (int i = 0; i < postitionsTransforms.Length; i++)
        {
            if (postitionsTransforms[i] != transform)
            {
                posNodes.Add(postitionsTransforms[i]);
            }
        }

        for (int i = 0; i < posNodes.Count; i++)
        {
            Gizmos.color = baseColor;
            Gizmos.DrawWireSphere(posNodes[i].position, 0.5f);

            Gizmos.color = lineColor;
            Gizmos.DrawLine(posNodes[i].position, posNodes[i].position + posNodes[i].forward * 2);
        }
    }
}
