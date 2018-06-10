using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapScript : MonoBehaviour {

    public float lapTimer = 0f;
    public int lapCount = 0;
    public bool raceGoing = false;

    public Dictionary<int, float> lapTimes = new Dictionary<int, float>();

    public List<CheckPointScript> checkPoints;

    private void Start()
    {
        foreach (GameObject checkPoint in GameObject.FindGameObjectsWithTag("CheckPoint"))
        {
            checkPoints.Add(checkPoint.GetComponent<CheckPointScript>());
        }
    }


    // Update is called once per frame
    void Update () {
		if (raceGoing)
        {
            //Add to the lap timer every frame when the race is running
            lapTimer += Time.deltaTime;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        //Check if its the player
        if (other.CompareTag("Player"))
        {
            //Check if all the checkpoints have been 'hit'
            bool missedCheckPoint = false;

            for (int i = 0; i < checkPoints.Count; i++)
            {
                
                if (checkPoints[i].playerHasPassed == false)
                {
                    //only needs to update if a player has missed a check point
                    missedCheckPoint = true;
                    //Don't need to continue looping if a player has missed even 1 checkpoint
                    break;
                }
            }
            if (raceGoing)
            {
                if (missedCheckPoint == false)
                {
                    NextLap();
                }
            }
            else
            {
                Debug.Log("Starting the race");
                raceGoing = true;
            }
            //If the player has gone through every checkpoint
            
        }
        
    }

    private void NextLap()
    {
        Debug.Log("Lap number: " + lapCount + " | Lap Time: " + lapTimer);

        lapTimes.Add(lapCount, lapTimer);
        lapTimer = 0;
        lapCount += 1;

        //Set each checkpoint to have missed the player
        for (int i = 0; i < checkPoints.Count; i++)
        {
            checkPoints[i].playerHasPassed = false;
        }
    }


}
