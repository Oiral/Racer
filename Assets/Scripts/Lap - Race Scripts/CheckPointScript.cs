﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class CheckPointScript : MonoBehaviour {

    //public bool playerHasPassed;

    public List<GameObject> RacerHasPassed;

    private void OnDrawGizmos()
    {
        BoxCollider col = GetComponent<BoxCollider>();
        Gizmos.matrix = transform.localToWorldMatrix;
        Color colorToDraw = Color.red;
        colorToDraw.a = .5f;

        Gizmos.color = colorToDraw;
        Gizmos.DrawCube(Vector3.zero, col.size);

    }

    private void OnTriggerEnter(Collider other)
    {
        /*
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Passed");
            playerHasPassed = true;
        }
        */
        if (other.CompareTag("AI") || other.CompareTag("Player"))
        {
            if (!RacerHasPassed.Contains(other.gameObject))
            {
                RacerHasPassed.Add(other.gameObject);
            }
        }
    }
}
