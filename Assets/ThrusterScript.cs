using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrusterScript : MonoBehaviour {

    public int thrusterPower = 150;
    public float hoverHeight = 1f;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponentInParent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate () {

        Debug.DrawRay(transform.position, Vector3.down * hoverHeight, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, hoverHeight))
        {
            float distanceAway = Vector3.Distance(hit.point, transform.position);

            Debug.Log(1 - (distanceAway / hoverHeight));
            Vector3 thrustDir = transform.up * thrusterPower * Time.deltaTime;
            thrustDir = thrustDir * (1 - (distanceAway / hoverHeight));
            rb.AddForceAtPosition(thrustDir , transform.position);
        }
        
	}
}
