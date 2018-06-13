using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DistanceTrackerScript))]
[RequireComponent(typeof(HoverCarScript))]
public class RacingAI : MonoBehaviour {

    public Transform track;

    public HoverCarScript hoverScript;

    List<Transform> nodes;

    public float steering;
    public float waypointDistCheck = 15f;
    int currentNode = 0;

    [Header ("Pause Stuff")]
    public bool paused;
    Vector3 savedVelocity;
    Vector3 savedAngularVelocity;

    DistanceTrackerScript distanceTracker;

    private void Start()
    {
        hoverScript = GetComponent<HoverCarScript>();
        distanceTracker = GetComponent<DistanceTrackerScript>();

        Transform[] pathTransfrom = track.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransfrom.Length; i++)
        {
            if (pathTransfrom[i] != track.transform)
            {
                nodes.Add(pathTransfrom[i]);
            }
        }
        PlayerPauseScript.pauseEvent.AddListener(ToggleAIPause);
    }

    private void FixedUpdate()
    {
        if (!paused)
        {
            ApplySteering();
            Drive();
            CheckWaypoint();
            Debug.DrawRay(transform.position, nodes[currentNode].transform.position - transform.position);
        }
    }

    void ApplySteering()
    {
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currentNode].position);
        //Debug.Log(relativeVector);
        steering = (relativeVector.x / relativeVector.magnitude);

        steering = steering * (1 + (distanceTracker.distanceToPlayer / 10000));
        hoverScript.currTurn = steering;
    }

    void Drive()
    {
        float absSteering = Mathf.Abs(steering);

        float inverseSteering = (1 - absSteering);

        float thrust = Mathf.Lerp(hoverScript.currThrust, ((inverseSteering + (absSteering / 2)) * hoverScript.forwardAcl * 1.15f), 0.05f);

        thrust = thrust * (1 + (distanceTracker.distanceToPlayer / 10000));

        hoverScript.currThrust = thrust;
        //hoverScript.currThrust = Mathf.Lerp(hoverScript.currThrust, (((1 - (Mathf.Sign(steering) * steering)) + (Mathf.Sign(steering) * steering)/4) * hoverScript.forwardAcl * 1.01f), 0.05f);

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
        Vector3 zeroPos = transform.position;
        Vector3 zeroNodePos = nodes[currentNode].position;

        zeroPos.y = zeroNodePos.y = 0;

        waypointDistCheck = waypointDistCheck * (1 + distanceTracker.distanceToPlayer / 100000);

        waypointDistCheck = Mathf.Clamp(waypointDistCheck, 1.5f, 15f);

        if (Vector3.Distance(zeroPos, zeroNodePos) < waypointDistCheck)
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

    void ToggleAIPause()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        paused = !paused;

        if (paused) //If the game has just gotten pause
        {
            savedVelocity = rb.velocity;
            rb.velocity = Vector3.zero;

            savedAngularVelocity = rb.angularVelocity;
            rb.angularVelocity = Vector3.zero;
        }
        else
        {
            rb.velocity = savedVelocity;
            rb.angularVelocity = savedAngularVelocity;
        }

        rb.isKinematic = paused;
    }
}
