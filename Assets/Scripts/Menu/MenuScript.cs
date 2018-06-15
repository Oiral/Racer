﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{

    public void LoadVechicleSelection()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel(int levelNumber)
    {
        SceneManager.LoadScene(levelNumber);
    }

    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }




    #region Only for Main Menu

    public GameObject startNodeParent;
    public GameObject settingsNodeParent;

    public CameraTrackingScript camTracking;

    public GameObject settingsUI;
    [Header("Sliders")]
    public Slider mainVolumeSlider;


    public bool inSettings;

    public void SelectSettings()
    {
        startNodeParent.SetActive(false);
        settingsNodeParent.SetActive(true);

        inSettings = true;

        settingsNodeParent.GetComponent<MenuCamScript>().menuActive = true;
        startNodeParent.GetComponent<MenuCamScript>().menuActive = false;

        settingsUI.SetActive(true);

        settingsNodeParent.GetComponent<MenuCamScript>().SetNode(0);
    }

    public void SelectTopMenu()
    {
        startNodeParent.SetActive(true);
        settingsNodeParent.SetActive(false);

        inSettings = false;

        settingsNodeParent.GetComponent<MenuCamScript>().menuActive = false;
        startNodeParent.GetComponent<MenuCamScript>().menuActive = true;

        settingsUI.SetActive(false);

        startNodeParent.GetComponent<MenuCamScript>().SetNode(0);
    }

    #endregion
}
