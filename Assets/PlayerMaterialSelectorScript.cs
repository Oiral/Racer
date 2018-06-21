using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class PlayerMaterialSelectorScript : MonoBehaviour {

    public static PlayerMaterialSelectorScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance != this)
        {
            Destroy(instance.gameObject);
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += LevelLoad;
    }

    public Material selectedMat;

    private void LevelLoad(Scene scene, LoadSceneMode mode)
    {
        //if the player is in the scene
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            Debug.Log("Player was Found");
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            foreach (SkinnedMeshRenderer renderer in player.GetComponentsInChildren<SkinnedMeshRenderer>())
            {
                Debug.Log("Found Renderer");
                Material[] mats = renderer.materials;
                
                mats[1] = selectedMat;
                renderer.materials = mats;
            }

            //remove this gameobject
            SceneManager.sceneLoaded -= LevelLoad;
            Destroy(gameObject);
        }else
        {
            Debug.Log("Player was not found");
        }
    }

    public void SetMat(Material mat)
    {
        selectedMat = mat;
    }

    public void LoadMainGame()
    {
        SceneManager.LoadScene(2);
    }

    public void SelectedSkin(string nameOfSkin)
    {
        Analytics.CustomEvent("Selected Skin - " + nameOfSkin);
    }


}
