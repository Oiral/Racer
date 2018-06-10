using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceStartScript : MonoBehaviour {

    public float xRot = 2;
    public float yRot = 10;
    public float zRot = 0.1f;

    public GameObject StartingUIGameObject;
    public Text countDownText;

    public CameraTrackingScript camTracking;

    List<RacingAI> AIScripts = new List<RacingAI>();
    List<HoverCarScript> PlayerScripts = new List<HoverCarScript>();

    private void Start()
    {
        foreach (GameObject aiCar in GameObject.FindGameObjectsWithTag("AI"))
        {
            AIScripts.Add(aiCar.GetComponent<RacingAI>());
        }
        foreach (GameObject playercar in GameObject.FindGameObjectsWithTag("Player"))
        {
            PlayerScripts.Add(playercar.GetComponent<HoverCarScript>());
        }

        TogglePlayer(false);
        ToggleAI(false);
        StartCoroutine(RaceStartCoroutine());

    }

    IEnumerator RaceStartCoroutine()
    {
        StartingUIGameObject.SetActive(true);

        camTracking.rotationLinked = true;
        camTracking.moveStiffness = .5f;
        camTracking.rotationStiffness = 1f;

        float secondLength = 1.5f;

        yield return new WaitForSeconds(secondLength);
        countDownText.text = "3";

        yield return new WaitForSeconds(secondLength);
        countDownText.text = "2";

        yield return new WaitForSeconds(secondLength);
        countDownText.text = "1";

        yield return new WaitForSeconds(secondLength);
        countDownText.text = "GO";


        camTracking.rotationLinked = false;

        camTracking.moveStiffness = 8;

        camTracking.xRotStiffness = xRot;
        camTracking.yRotStiffness = yRot;
        camTracking.zRotStiffness = zRot;

        TogglePlayer(true);
        ToggleAI(true);

        yield return new WaitForSeconds(secondLength);
        countDownText.text = "";
    }

    public void TogglePlayer(bool toggle)
    {
        for (int i = 0; i < PlayerScripts.Count; i++)
        {
            PlayerScripts[i].playerControled = toggle;
        }
    }

    public void ToggleAI(bool toggle)
    {
        for (int i = 0; i < AIScripts.Count; i++)
        {
            AIScripts[i].enabled = toggle;
        }
    }

}
