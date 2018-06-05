using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public List<GameObject> items;
    public int currentItem = 0;

    public CameraTrackingScript camTrackingScript;



    private void Start()
    {
        camTrackingScript.Target = items[currentItem];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NextItem();
        }
    }

    public void NextItem()
    {
        currentItem += 1;
        if (currentItem >= items.Count)
        {
            currentItem = 0;
        }
        camTrackingScript.Target = items[currentItem];
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
