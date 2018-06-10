using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointScript : MonoBehaviour {

    public bool playerHasPassed;


    private void OnDrawGizmosSelected()
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
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Passed");
            playerHasPassed = true;
        }
    }
}
