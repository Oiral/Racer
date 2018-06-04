using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class HoverCarScript : MonoBehaviour {

    Rigidbody rb;
    [Header("Info")]
    public float deadZone = 0.1f;
    public float speed;
    public Text speedoText;
    public bool isPlayer = true;

    [Header("Brake and Acceleration")]
    public float forwardAcl = 100f;
    public float backwardAcl = 25f;
    [HideInInspector]
    public float currThrust = 0f;

    [Header("Drag")]
    public float dragForceDead = 2f;
    public float dragForceActive = 0.5f;

    [Header("Turning")]
    public float turnStrength = 10f;
    public float turnWeaveStrength = 1f;
    [HideInInspector]
    public float currTurn = 0f;
    public GameObject turnPlate;
    public float turnPlateForce = 100f;

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

        if (isPlayer)
        {
            rb.drag = dragForceDead;
            //Main Thrust
            currThrust = 0f;
            float aclAxis = ControllerMapping.TriggerAxis();
            if (aclAxis > deadZone)
            {
                currThrust = aclAxis * forwardAcl;
                rb.drag = dragForceActive;
            }
            else if (aclAxis < -deadZone)
            {
                currThrust = aclAxis * backwardAcl;
                rb.drag = dragForceActive;
            }

            //Turning
            currTurn = 0f;
            float turnAxis = ControllerMapping.HorizontalMovement();
            if (Mathf.Abs(turnAxis) > deadZone)
            {
                currTurn = turnAxis;
            }
            currTurn = Mathf.Sign(currThrust) * currTurn;
        }
	}

    private void FixedUpdate()
    {
        //Forward
        if (Mathf.Abs(currThrust) > 0)
        {
            float forceToAdd;

            forceToAdd = Mathf.Pow(0.1f * currThrust - 2, 3) + 9;

            rb.AddForce(transform.forward * forceToAdd);
        }

        //Turning
        if (currTurn != 0)
        {
            if (turnPlate == null)
            {
                //rb.AddTorque(Vector3.up * currTurn * turnStrength);
                float zRot = transform.rotation.eulerAngles.z;
                if (zRot > 180)
                {
                    zRot = 360 - zRot;
                }

                rb.AddRelativeTorque(Vector3.up * currTurn * turnStrength * (1 * (zRot/30) + 1));
                rb.AddRelativeTorque(Vector3.forward * -currTurn * turnWeaveStrength);
            }
            else
            {
                rb.AddForceAtPosition(Mathf.Sign(currTurn) * -transform.right * turnPlateForce, turnPlate.transform.position);
            }
        }



        //Hovers
        RaycastHit hit;
        bool onGround = false;

        RaycastHit carHit;
        Vector3 relativeVector = new Vector3(0,1,0);
        if (Physics.Raycast(transform.position,-Vector3.up,out carHit, 20, layerMask))
        {
            relativeVector = carHit.normal;
        }

        for (int i = 0; i < hoverPoints.Length; i++)
        {
            float hoverForce = hoverPoints[i].GetComponent<ThrusterScript>().hoverForce;
            var hoverPoint = hoverPoints[i];

            Vector3 hoverPointPos = hoverPoint.transform.position;
            hoverPointPos = hoverPointPos - relativeVector;

            if (Physics.Raycast(hoverPoint.transform.position,-Vector3.up,out hit, hoverHeight, layerMask))
            {
                rb.AddForceAtPosition(relativeVector * hoverForce * (1 - (hit.distance / hoverHeight)), hoverPoint.transform.position);
                onGround = true;
            }else
            {
                if ((transform.position - relativeVector).y > hoverPointPos.y)
                {
                    rb.AddForceAtPosition(relativeVector * hoverForce/3, hoverPoint.transform.position);
                }
                else
                {
                    rb.AddForceAtPosition(relativeVector * -hoverForce/3, hoverPoint.transform.position);
                }
            }
        }
        //Make the car fall faster
        if (!onGround)
        {
            rb.AddForce(-Vector3.up * 50 , ForceMode.Acceleration);
        }

        Vector3 vel = rb.velocity;
        vel.y = 0;
        speed = vel.magnitude;
        if (speedoText != null)
        {
            speedoText.text = Mathf.RoundToInt(speed).ToString() + " m/s";
        }
    }
    
}
