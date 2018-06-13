using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<HoverCarScript>())
        {
            HoverCarScript hoverScript = other.gameObject.GetComponent<HoverCarScript>();

            hoverScript.forwardAcl = 400;
            hoverScript.boosting = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<HoverCarScript>())
        {
            HoverCarScript hoverScript = other.gameObject.GetComponent<HoverCarScript>();

            hoverScript.forwardAcl = 250;
            hoverScript.boosting = false;
        }
    }
}
