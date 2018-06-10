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
        hoverScript.currThrust = Mathf.Lerp(hoverScript.currThrust, (((1 - (Mathf.Sign(steering) * steering)) + (Mathf.Sign(steering) * steering)/4) * hoverScript.forwardAcl), 0.05f);
        Rigidbody rb = GetComponent<Rigidbody>();
        if (hoverScript.currThrust < 100)
        {
            rb.drag = hoverScript.dragForceDead;
            //Debug.Log("Less drag force");
        }
        else
        {
            rb.drag = hoverScript.dragForceActive;
        }
    }

    void CheckWaypoint()
    {
        if (Vector3.Distance(transform.position, nodes[currentNode].position) < 15f)
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
