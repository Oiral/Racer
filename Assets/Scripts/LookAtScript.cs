﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour {

    public GameObject target;

    private void Update()
    {
        transform.LookAt(target.transform);
    }
}
