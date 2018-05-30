using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HoverCarScript : MonoBehaviour {

    Rigidbody rb;
    public float deadZone = 0.1f;

    [Header("Brake and Acceleration")]
    public float forwardAcl = 100f;
    public float backwardAcl = 25f;
    float currThrust = 0f;


    [Header("Drag")]
    public float dragForceDead = 2f;
    public float dragForceActive = 0.5f;


    [Header("Turning")]
    public float turnStrength = 10f;
    public float turnWeaveStrength = 1f;
    float currTurn = 0f;

    [Header("Hovers")]
    //public float hoverForce = 9f;
    public float hoverHeight = 2f;
    int layerMask;
    public GameObject[] hoverPoints;

    
    void Start () {
        rb = GetComponent<Rigidbody>();

        layerMask = 1 << LayerMask.NameToLayer("Car");
        layerMask = ~layerMask;
	}
	
	void Update() {
        rb.drag = dragForceDead;
        //Main Thrust
        currThrust = 0f;
        float aclAxis = Input.GetAxis("Vertical");
        if (aclAxis > deadZone)
        {
            currThrust = aclAxis * forwardAcl;
            rb.drag = dragForceActive;
        }else if (aclAxis < -deadZone)
        {
            currThrust = aclAxis * backwardAcl;
            rb.drag = dragForceActive;
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
        bool onGround = false;
        for (int i = 0; i < hoverPoints.Length; i++)
        {
            float hoverForce = hoverPoints[i].GetComponent<ThrusterScript>().hoverForce;
            var hoverPoint = hoverPoints[i];
            if (Physics.Raycast(hoverPoint.transform.position,-Vector3.up,out hit, hoverHeight, layerMask))
            {
                rb.AddForceAtPosition(Vector3.up * hoverForce * (1 - (hit.distance / hoverHeight)), hoverPoint.transform.position);
                onGround = true;
            }else
            {
                if (transform.position.y > hoverPoint.transform.position.y)
                {
                    rb.AddForceAtPosition(hoverPoint.transform.up * hoverForce/3, hoverPoint.transform.position);
                }
                else
                {
                    rb.AddForceAtPosition(hoverPoint.transform.up * -hoverForce/3, hoverPoint.transform.position);
                }
            }
        }
        //Make the car fall faster
        if (!onGround)
        {
            rb.AddForce(-Vector3.up * 50 , ForceMode.Acceleration);
        }



    }
}
