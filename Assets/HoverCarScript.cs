using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HoverCarScript : MonoBehaviour {

    Rigidbody rb;
    float deadZone;

    public float forwardAcl = 100f;
    public float backwardAcl = 25f;
    float currThrust = 0f;

    public float turnStrength = 10f;
    public float turnWeaveStrength = 1f;
    float currTurn = 0f;

    int layerMask;
    public float hoverForce = 9f;
    public float hoverHeight = 2f;
    public GameObject[] hoverPoints;
    
	void Start () {
        rb = GetComponent<Rigidbody>();

        layerMask = 1 << LayerMask.NameToLayer("Car");
        layerMask = ~layerMask;
	}
	
	void Update () {
        //Main Thrust
        currThrust = 0f;
        float aclAxis = Input.GetAxis("Vertical");
        if (aclAxis > deadZone)
        {
            currThrust = aclAxis * forwardAcl;
        }else if (aclAxis < deadZone)
        {
            currThrust = aclAxis * backwardAcl;
        }

        //Turning
        currTurn = 0f;
        float turnAxis = Input.GetAxis("Horizontal");
        if (Mathf.Abs(turnAxis) > deadZone)
        {
            currTurn = turnAxis;
        }
	}

    private void FixedUpdate()
    {
        //Forward
        if (Mathf.Abs(currThrust) > 0)
        {
            rb.AddForce(transform.forward * currThrust);
        }

        //Turning
        if (currTurn != 0)
        {
            rb.AddRelativeTorque(Vector3.up * currTurn * turnStrength);
            rb.AddRelativeTorque(Vector3.forward * -currTurn * turnWeaveStrength);
        }

        //Hovers
        RaycastHit hit;
        for (int i = 0; i < hoverPoints.Length; i++)
        {
            var hoverPoint = hoverPoints[i];
            if (Physics.Raycast(hoverPoint.transform.position,-Vector3.up,out hit, hoverHeight, layerMask))
            {
                rb.AddForceAtPosition(Vector3.up * hoverForce * (1 - (hit.distance / hoverHeight)), hoverPoint.transform.position);
            }else
            {
                if (transform.position.y > hoverPoint.transform.position.y)
                {
                    rb.AddForceAtPosition(hoverPoint.transform.up * hoverForce/2, hoverPoint.transform.position);
                }
                else
                {
                    rb.AddForceAtPosition(hoverPoint.transform.up * -hoverForce/2, hoverPoint.transform.position);
                }
            }
        }



    }
}
