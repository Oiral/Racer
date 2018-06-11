using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerPauseScript : MonoBehaviour {

    public static UnityEvent pauseEvent = new UnityEvent();

    public bool paused;

    public Vector3 savedVelocity;
    public Vector3 savedAngularVelocity;

    private void Start()
    {
        pauseEvent.AddListener(TogglePausePlayer);
    }

    private void Update()
    {
        //Pause the game
        if (ControllerMapping.instance.GetStartDown())
        {
            pauseEvent.Invoke();
            Debug.Log("Trying to pause game");
        }
    }

    void TogglePausePlayer()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        HoverCarScript playerHoverScript = GetComponent<HoverCarScript>();

        paused = !paused;

        if (paused) //If the game has just gotten pause
        {
            savedVelocity = rb.velocity;
            rb.velocity = Vector3.zero;

            savedAngularVelocity = rb.angularVelocity;
            rb.angularVelocity = Vector3.zero;
        }
        else
        {
            rb.velocity = savedVelocity;
            rb.angularVelocity = savedAngularVelocity;
        }


        rb.isKinematic = paused;
        playerHoverScript.playerControled = !paused;
        Debug.Log("Player has toggled pause");
    }


}
