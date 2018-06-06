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
    //public GameObject turnPlate;
    //public float turnPlateForce = 100f;

    [Header("Hovers")]
    //public float hoverForce = 9f;
    public float hoverHeight = 2f;
    public LayerMask layerMask;
    public GameObject[] hoverPoints;

    
    void Start () {
        rb = GetComponent<Rigidbody>();
        //layerMask = 1 << LayerMask.NameToLayer("Car");
        //layerMask = ~layerMask;
	}
	
	void Update() {

        if (isPlayer)
        {
            rb.drag = dragForceDead;
            //Main Thrust
            currThrust = 0f;
            float aclAxis = ControllerMapping.instance.TriggerAxis();
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
            float turnAxis = ControllerMapping.instance.HorizontalMovement();
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
            //rb.AddTorque(Vector3.up * currTurn * turnStrength);
            float zRot = transform.rotation.eulerAngles.z;
            if (zRot > 180)
            {
                zRot = 360 - zRot;
            }

            rb.AddRelativeTorque(Vector3.up * currTurn * turnStrength * (1 * (zRot / 30) + 1));
            rb.AddRelativeTorque(Vector3.forward * -currTurn * turnWeaveStrength);
        }
        



        //Hovers
        RaycastHit hit;
        bool onGround = false;

        //Get each hover
        for (int i = 0; i < hoverPoints.Length; i++)
        {
            
            var hoverPoint = hoverPoints[i];
            float hoverForce = hoverPoint.GetComponent<ThrusterScript>().hoverForce;

            //Find the relative height of the hover releative to the body of the car and the normal of the base of the car
            Vector3 hoverPointPos = hoverPoint.transform.position;

            if (Physics.Raycast(hoverPoint.transform.position,-Vector3.up,out hit, hoverHeight, layerMask))
            {
                //if the hovers are near the ground
                rb.AddForceAtPosition(transform.up * hoverForce * (1 - (hit.distance / hoverHeight)), 
                    hoverPoint.transform.position);

                //Set this for later use
                onGround = true;
            }else
            {
                if (transform.position.y > hoverPointPos.y)
                {
                    //If the hovers are off the ground but are lower than the main body of the car
                    rb.AddForceAtPosition(transform.up * hoverForce/3, 
                        hoverPoint.transform.position);
                }
                else
                {
                    //If the hovers are off the ground but are higher than the main body of the car
                    rb.AddForceAtPosition(transform.up * -hoverForce/3, 
                        hoverPoint.transform.position);
                }
            }
        }

        //Make the car fall faster if its not on the ground
        if (!onGround)
        {
            rb.AddForce(-Vector3.up * 50 , ForceMode.Acceleration);
        }


        //Find the speed of the car
        Vector3 vel = rb.velocity;
        vel.y = 0;
        speed = vel.magnitude;
        //Display the speed of the text to the UI
        if (speedoText != null)
        {
            speedoText.text = Mathf.RoundToInt(speed).ToString() + " m/s";
        }
    }
    
}
