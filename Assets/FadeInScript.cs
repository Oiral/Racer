using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeInScript : MonoBehaviour {

    public List<Image> imagesToFadeIn;
    public List<float> imagesTargetAlpha;

    private void Awake()
    {
        for (int i = 0; i < imagesToFadeIn.Count; i++)
        {
            imagesTargetAlpha.Add(imagesToFadeIn[i].color.a);

            Color col = imagesToFadeIn[i].color;
            col.a = 0;
            imagesToFadeIn[i].color = col;
        }
    }

    private void Update()
    {
        for (int i = 0; i < imagesToFadeIn.Count; i++)
        {
            Color col = imagesToFadeIn[i].color;
            col.a += 0.01f;

            col.a = Mathf.Clamp(col.a, 0, imagesTargetAlpha[i]);

            imagesToFadeIn[i].color = col;
        }

        ControllerMapping mapping = ControllerMapping.instance;

        if (mapping.GetADown() || mapping.GetBDown() || mapping.GetYDown() || mapping.GetXDown())
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
    }
}
