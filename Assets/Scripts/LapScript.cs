using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider))]
public class LapScript : MonoBehaviour {

    public float lapTimer = 0f;
    public int lapCount = 1;
    public bool raceGoing = false;

    public int maxlaps;

    public Dictionary<int, float> lapTimes = new Dictionary<int, float>();

    public List<CheckPointScript> checkPoints;

    public static UnityEvent playerNextLap = new UnityEvent();

    private void OnDrawGizmosSelected()
    {
        BoxCollider col = GetComponent<BoxCollider>();
        Gizmos.matrix = transform.localToWorldMatrix;
        Color colorToDraw = Color.white;
        colorToDraw.a = .5f;

        Gizmos.color = colorToDraw;
        Gizmos.DrawCube(Vector3.zero, col.size);
    }

    private void Start()
    {
        
        if (checkPoints.Count <= 0)
        {
            foreach (GameObject checkPoint in GameObject.FindGameObjectsWithTag("CheckPoint"))
            {
                checkPoints.Add(checkPoint.GetComponent<CheckPointScript>());
            }
        }

        playerNextLap.AddListener(NextLap);

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
                
                if (checkPoints[i].RacerHasPassed.Contains(other.gameObject) == false)
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
                    other.gameObject.GetComponent<DistanceTrackerScript>().NextLap();
                    NextLap();
                }
            }
            else
            {
                Debug.Log("Starting the race");
                raceGoing = true;
            }
            //If the player has gone through every checkpoint
            
        }else if (other.CompareTag("AI"))
        {
            AIPassedStart(other.gameObject);
        }
        
        
    }

    public void AIPassedStart(GameObject AI)
    {
        if (raceGoing)
        {
            for (int i = 0; i < checkPoints.Count; i++)
            {

                if (checkPoints[i].RacerHasPassed.Contains(AI.gameObject))
                {
                    checkPoints[i].RacerHasPassed.Remove(AI.gameObject);
                }
            }

            AI.gameObject.GetComponent<DistanceTrackerScript>().NextLap();
        }
    }

    private void NextLap()
    {
        //Check if the lap is the last lap
        if (lapCount >= maxlaps)
        {
            //Finish the race
            FinishLap();
        }

        Debug.Log("Lap number: " + lapCount + " | Lap Time: " + lapTimer);

        //Add one to the lap counter
        lapTimes.Add(lapCount, lapTimer);
        lapTimer = 0;
        lapCount += 1;

        //Set each checkpoint to have missed the player
        for (int i = 0; i < checkPoints.Count; i++)
        {
            checkPoints[i].RacerHasPassed.Remove(GameObject.FindGameObjectWithTag("Player"));
        }
    }

    private void FinishLap()
    {
        Debug.Log("You finished!");
        Debug.Break();
    }

}