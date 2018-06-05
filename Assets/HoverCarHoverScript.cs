using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverCarHoverScript : MonoBehaviour {

    public float hoverForce = 900f;
    public float hoverHeight = 2f;

    public GameObject[] hoverPoints;

    public LayerMask layerMask;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        RaycastHit carHit;
        Vector3 relativeVector = new Vector3(0, 1, 0);
        if (Physics.Raycast(transform.position, -Vector3.up, out carHit, 20, layerMask))
        {
            relativeVector = carHit.normal;
        }

        for (int i = 0; i < hoverPoints.Length; i++)
        {
            float hoverForce = hoverPoints[i].GetComponent<ThrusterScript>().hoverForce;
            var hoverPoint = hoverPoints[i];

            Vector3 hoverPointPos = hoverPoint.transform.position;
            hoverPointPos = hoverPointPos - relativeVector;

            if (Physics.Raycast(hoverPoint.transform.position, -Vector3.up, out hit, hoverHeight, layerMask))
            {
                rb.AddForceAtPosition(relativeVector * hoverForce * (1 - (hit.distance / hoverHeight)), hoverPoint.transform.position);
            }
        }
    }
}
