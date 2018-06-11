using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTracker : MonoBehaviour {

    public List<GameObject> Racers = new List<GameObject>();

	// Use this for initialization
	void Start () {
        foreach (DistanceTrackerScript racer in GameObject.FindObjectsOfType(typeof(DistanceTrackerScript)))
        {
            Racers.Add(racer.gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
        Racers.Sort(SortByDistance);
	}

    static int SortByDistance(GameObject p2, GameObject p1)
    {
        return p1.GetComponent<DistanceTrackerScript>().distanceAroundTrack.CompareTo((p2.GetComponent<DistanceTrackerScript>().distanceAroundTrack));
    }


}
