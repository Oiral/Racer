using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMaterialSelectorScript : MonoBehaviour {

    private void Awake()
    {
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

}
