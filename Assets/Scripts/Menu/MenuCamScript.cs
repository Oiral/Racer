using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCamScript : MonoBehaviour {

    public List<Transform> camNodes;
    public Transform menuSlots;
    public int currentNode = 0;

    public CameraTrackingScript camTracking;

    public float coolDownTime = 1f;
    public bool onCoolDown;

    Coroutine coolDown;

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

        if (ControllerMapping.instance.GetBackDown())
        {
            if (SceneManager.GetActiveScene().buildIndex > 0)
            {
                SceneManager.LoadScene(0);
            }else if (GameObject.FindGameObjectWithTag("Menu Controller")!= null && GameObject.FindGameObjectWithTag("Menu Controller").GetComponent<MenuScript>().inSettings)
            {
                GameObject.FindGameObjectWithTag("Menu Controller").GetComponent<MenuScript>().SelectTopMenu();
            }
            //Go back in the menu!
            //load scene 0
            //if scene 0 dont load?
            //if scene 0 and not on main track go back to main track!
        }

    }

    public void SetNode(int nodeToSet)
    {
        Deselect();
        currentNode = nodeToSet;
        Select();
        camTracking.Target = camNodes[currentNode].gameObject;
    }

    public void NextItem()
    {
        coolDown = StartCoroutine(StartCoolDown());
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
        coolDown = StartCoroutine(StartCoolDown());
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

    private void OnDisable()
    {
        StopCoroutine(coolDown);
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
