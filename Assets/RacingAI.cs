using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingAI : MonoBehaviour {

    public Transform track;

    public HoverCarScript hoverScript;

    List<Transform> nodes;

    public float steering;

    int currentNode = 0;

    private void Start()
    {
        hoverScript = GetComponent<HoverCarScript>();
        Transform[] pathTransfrom = track.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransfrom.Length; i++)
        {
            if (pathTransfrom[i] != track.transform)
            {
                nodes.Add(pathTransfrom[i]);
            }
        }
    }

    private void FixedUpdate()
    {
        ApplySteering();
        Drive();
        CheckWaypoint();
    }

    void ApplySteering()
    {
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currentNode].position);
        //Debug.Log(relativeVector);
        steering = (relativeVector.x / relativeVector.magnitude);
        hoverScript.currTurn = steering;
    }

    void Drive()
    {
        hoverScript.currThrust = (1 - (Mathf.Sign(steering) * steering)) * hoverScript.forwardAcl;
    }

    void CheckWaypoint()
    {
        if (Vector3.Distance(transform.position, nodes[currentNode].position) < 10f)
        {
            if (currentNode == nodes.Count - 1)
            {
                currentNode = 0;
            }
            else
            {
                currentNode++;
            }
        }
    }
}
