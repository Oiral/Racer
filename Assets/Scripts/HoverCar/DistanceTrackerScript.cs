﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceTrackerScript : MonoBehaviour {

    List<CheckPointScript> checkPoints = new List<CheckPointScript>();

    int currentCheckPoint;

    GameObject startLine;

    float distanceToCheckpoint;
    public float distanceAroundTrack;
    //Needs to be changed to total distance / position
    public Text distanceText;

    GameObject targetCheck;

    bool checkingForPoints;

    public float lapLength;

    public int laps = 0;
    public float totalDistance;

    public float distanceToPlayer;
    GameObject player;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        startLine = GameObject.FindGameObjectWithTag("Start Line");
        checkPoints = startLine.GetComponent<LapScript>().checkPoints;
        CalculateLapLength();

        targetCheck = checkPoints[0].gameObject;
        checkingForPoints = true;
    }

    void CalculateLapLength()
    {
        lapLength += DistanceBetweenCheckpoints(0, startLine);

        for (int i = 1; i < checkPoints.Count; i++)
        {
            lapLength += DistanceBetweenCheckpoints(i,i-1);
        }

        lapLength += DistanceBetweenCheckpoints(checkPoints.Count -1,startLine);
    }

    private void Update()
    {
        if (checkingForPoints)
        {
            if (checkPoints[currentCheckPoint].RacerHasPassed.Contains(gameObject))
            {
                NextCheckPoint();
            }
        }

        distanceToCheckpoint = DistanceBetweenCheckpoints(currentCheckPoint,gameObject);
        CalculateDistanceAroundTrack();

        totalDistance = distanceAroundTrack + ((laps) * lapLength);

        if (distanceText != null)
        {
            distanceText.text = distanceAroundTrack.ToString() + "m";
        }

        if (player != gameObject)
        {
            FindDistanceToPlayer();
        }
        else
        {
            //Debug.Log(totalDistance);
        }

    }

    private void NextCheckPoint()
    {
        currentCheckPoint += 1;

        if (currentCheckPoint > checkPoints.Count - 1)
        {
            currentCheckPoint = 0;
            targetCheck = startLine;
            checkingForPoints = false;
        }
        else
        {
            targetCheck = checkPoints[currentCheckPoint].gameObject;
        }
    }

    public void NextLap()
    {
        laps += 1;
        checkingForPoints = true;
        //Debug.Log("Lap!");
        currentCheckPoint = 0;
        targetCheck = checkPoints[currentCheckPoint].gameObject;
    }

    //Current Lap Distance = distance to next marker + all passed markers distance from start
    void CalculateDistanceAroundTrack()
    {
        //Debug.Log("Running?");
        float distanceBetweenCheckpoint = 0;

        //check our current checkpoint distance
        if (currentCheckPoint == 0 && targetCheck != startLine)
        {
            //Check distance from start to check point 1
            distanceBetweenCheckpoint = DistanceBetweenCheckpoints(currentCheckPoint, startLine);
        }else if (targetCheck == startLine)
        {
            //Check the distance from last to start
            distanceBetweenCheckpoint = DistanceBetweenCheckpoints(checkPoints.Count - 1, startLine);
        }
        else
        {
            distanceBetweenCheckpoint = DistanceBetweenCheckpoints(currentCheckPoint, startLine);
        }

        distanceAroundTrack = distanceBetweenCheckpoint - distanceToCheckpoint;

        //check previous checkpoint distance
        if (currentCheckPoint != 0)
        {
            //loop through all the checkpoints before the current one
            for (int i = 1; i < currentCheckPoint; i++)
            {
                distanceAroundTrack += DistanceBetweenCheckpoints(i, i-1);
                
            }
        }else if (targetCheck == startLine)
        {
            //loop through all the checkpoints before the current one
            for (int i = 1; i < checkPoints.Count; i++)
            {
                distanceAroundTrack += DistanceBetweenCheckpoints(i, i - 1);

            }
        }

    }

    float DistanceBetweenCheckpoints(int check1,int check2)
    {
        Vector3 CheckPointPos = checkPoints[check1].gameObject.transform.position;
        Vector3 PrevCheckPointPos = checkPoints[check2].gameObject.transform.position;

        CheckPointPos.y = PrevCheckPointPos.y = 0;

        return Vector3.Distance(CheckPointPos, PrevCheckPointPos);
    }

    float DistanceBetweenCheckpoints(int checkpoint,GameObject extraCheckpoint)
    {
        Vector3 CheckPointPos = checkPoints[checkpoint].gameObject.transform.position;
        Vector3 PrevCheckPointPos = extraCheckpoint.transform.position;

        CheckPointPos.y = PrevCheckPointPos.y = 0;

        return Vector3.Distance(CheckPointPos, PrevCheckPointPos);
    }

    //Find Distance Between two players
    //If my current lap != your current lap (more math stuff)

    void FindDistanceToPlayer()
    {
        float playerDistance = player.GetComponent<DistanceTrackerScript>().totalDistance;

        distanceToPlayer = playerDistance - totalDistance;
        //Debug.Log(distanceToPlayer);

    }
}
