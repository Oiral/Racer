using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionTextScript : MonoBehaviour {

    Text myText;

    PositionTracker posTracker;

	// Use this for initialization
	void Start () {
        myText = GetComponent<Text>();
        posTracker = GameObject.FindGameObjectWithTag("Start Line").GetComponent<PositionTracker>();
	}
	
	// Update is called once per frame
	void Update () {
        myText.text = (posTracker.Racers.IndexOf(GameObject.FindGameObjectWithTag("Player")) + 1).ToString();
	}
}
