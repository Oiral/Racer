using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverBaseScript : MonoBehaviour
{

    public Mesh gizmoMesh;

    Rigidbody rb;
    [Header("Info")]
    public float deadZone = 0.1f;
    public float speed;
    // public Text speedoText;
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

    public LayerMask layerMask;
    /*
    [Header("Hovers")]
    //public float hoverForce = 9f;
    public float hoverHeight = 2f;
    
    public GameObject[] hoverPoints;*/

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireMesh(gizmoMesh, -1, transform.position, transform.rotation, new Vector3(2, 0.1f, 4));
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
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
            rb.AddTorque(Vector3.up * currTurn * turnStrength);
            /*
            float zRot = transform.rotation.eulerAngles.z;
            if (zRot > 180)
            {
                zRot = 360 - zRot;
            }

            rb.AddRelativeTorque(Vector3.up * currTurn * turnStrength  *(1 * (zRot / 30) + 1));*/
            //rb.AddRelativeTorque(Vector3.forward * -currTurn * turnWeaveStrength);
        }



        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, 10, layerMask))
        {
            Debug.DrawRay(hit.point, hit.normal * 10);
            transform.rotation = Quaternion.LookRotation(transform.forward, hit.normal);
            Vector3 pos = transform.position;
            pos = hit.point + hit.normal*2;
            transform.position = pos;
        }
    }
}
