using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeChangerScript : MonoBehaviour {

    public GameObject playerHoverCar;

    public GameObject AChallenge;
    public GameObject BChallenge;
    public GameObject YChallenge;
    public GameObject XChallenge;

    // Update is called once per frame
    void Update () {
		if (ControllerMapping.instance.GetADown())
        {
            Debug.Log("A");
            MovePlayerTo(AChallenge);
        }
        if (ControllerMapping.instance.GetBDown())
        {
            Debug.Log("B");
            MovePlayerTo(BChallenge);
        }
        if (ControllerMapping.instance.GetYDown())
        {
            Debug.Log("Y");
            MovePlayerTo(YChallenge);
        }
        if (ControllerMapping.instance.GetXDown())
        {
            Debug.Log("X");
            MovePlayerTo(XChallenge);
        }
    }

    public void MovePlayerTo(GameObject destination)
    {
        playerHoverCar.GetComponent<Rigidbody>().velocity = Vector3.zero;
        playerHoverCar.transform.position = destination.transform.position;
        playerHoverCar.transform.rotation = destination.transform.rotation;
    }

}
