using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTimerScript : MonoBehaviour {

    public float lapTimer = 0f;
    public int lapCount = 0;
    public bool raceGoing = false;

    public Dictionary<int, float> lapTimes = new Dictionary<int, float>();

	// Update is called once per frame
	void Update () {
		if (raceGoing)
        {
            lapTimer += Time.deltaTime;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (raceGoing)
        {
            Debug.Log("Lap number: " + lapCount + " | Lap Time: " + lapTimer);

            lapTimes.Add(lapCount, lapTimer);
            lapTimer = 0;
            lapCount += 1;
        }
        else
        {
            raceGoing = true;
        }
    }
}
