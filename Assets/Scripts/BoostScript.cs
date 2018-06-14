using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScript : MonoBehaviour {

    public float boostAmount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<HoverCarScript>())
        {
            HoverCarScript hoverScript = other.gameObject.GetComponent<HoverCarScript>();

            hoverScript.forwardAcl = boostAmount;
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
