using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamScript : MonoBehaviour {

    public List<Transform> camNodes;
    public Transform menuSlots;
    int currentNode = 0;

    public CameraTrackingScript camTracking;

    private void Start()
    {
        Transform[] camTransforms = menuSlots.GetComponentsInChildren<Transform>();
        camNodes = new List<Transform>();

        for (int i = 0; i < camTransforms.Length; i++)
        {
            if (camTransforms[i] != menuSlots)
            {
                camNodes.Add(camTransforms[i]);
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextItem();
        }
    }

    public void NextItem()
    {
        currentNode += 1;
        if (currentNode >= camNodes.Count)
        {
            currentNode = 0;
        }
        camTracking.Target = camNodes[currentNode].gameObject;
    }
}
