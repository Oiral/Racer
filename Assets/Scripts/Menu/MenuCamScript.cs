using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamScript : MonoBehaviour {

    public List<Transform> camNodes;
    public Transform menuSlots;
    public int currentNode = 0;

    public CameraTrackingScript camTracking;

    public float coolDownTime = 1f;
    public bool onCoolDown;

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
        //NextItem();
        //Select();
        NextItem();
        
    }

    private void Update()
    {

        if (ControllerMapping.instance.HorizontalMovement() > 0.2f && onCoolDown == false)
        {
            NextItem();
        }
        if (ControllerMapping.instance.HorizontalMovement() < -0.2f && onCoolDown == false)
        {
            PrevItem();
        }
        if (ControllerMapping.instance.GetSelectDown())
        {
            Debug.Log("Selecting Item!");
            if (camNodes[currentNode].GetComponent<CamPosScript>() != null)
            {
                camNodes[currentNode].GetComponent<CamPosScript>().OnSelection.Invoke();
            }
        }
    }

    public void NextItem()
    {
        StartCoroutine(StartCoolDown());
        Deselect();
        currentNode += 1;
        if (currentNode >= camNodes.Count)
        {
            currentNode = 0;
        }
        Select();
        camTracking.Target = camNodes[currentNode].gameObject;
    }

    public void PrevItem()
    {
        StartCoroutine(StartCoolDown());
        Deselect();
        currentNode -= 1;
        if (currentNode < 0)
        {
            currentNode = camNodes.Count - 1;
        }
        Select();
        camTracking.Target = camNodes[currentNode].gameObject;
    }

    IEnumerator StartCoolDown()
    {
        onCoolDown = true;
        yield return new WaitForSeconds(coolDownTime);
        onCoolDown = false;
    }

    void Select()
    {
        if (camNodes[currentNode].GetComponent<CamPosScript>() != null)
        {
            camNodes[currentNode].GetComponent<CamPosScript>().OnHover.Invoke();
        }
    }

    void Deselect()
    {
        if (camNodes[currentNode].GetComponent<CamPosScript>() != null)
        {
            camNodes[currentNode].GetComponent<CamPosScript>().LeaveHover.Invoke();
        }
    }

}
