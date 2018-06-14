using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour {
    
    public GameObject visualOfBike;
    LapScript lapScript;

    private void Start()
    {
        lapScript = GameObject.FindGameObjectWithTag("Start Line").GetComponent<LapScript>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        visualOfBike.SetActive(false);
        rb.isKinematic = true;

        yield return new WaitForSeconds(1);
        GameObject lastCheckpoint = FindLastPassedCheckpoint();

        transform.position = lastCheckpoint.transform.position;
        transform.rotation = lastCheckpoint.transform.rotation;

        visualOfBike.SetActive(true);
        rb.isKinematic = false;
        rb.velocity = Vector3.zero;

    }

    GameObject FindLastPassedCheckpoint()
    {
        for (int i = 0; i < lapScript.checkPoints.Count; i++)
        {
            if (lapScript.checkPoints[i].RacerHasPassed.Contains(gameObject) == false)
            {
                if (i == 0)
                {
                    return GameObject.FindGameObjectWithTag("Start Line");
                }
                return (lapScript.checkPoints[i -1].gameObject);
            }
        }
        Debug.LogError("Failed To Find Checkpoint");
        return GameObject.FindGameObjectWithTag("Start Line");
    }

}
