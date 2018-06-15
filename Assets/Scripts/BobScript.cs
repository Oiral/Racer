using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobScript : MonoBehaviour {

    public Vector3 startingPos;
	// Use this for initialization
	void Start () {
        startingPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = startingPos;
        pos.y = pos.y + Mathf.Sin(Time.time)/3;
        transform.position = pos;
	}
}
