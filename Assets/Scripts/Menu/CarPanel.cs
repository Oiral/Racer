using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarPanel : MonoBehaviour {



    public float backgroundPanelSelectedAlpha = 0.7f;
    public float textSelectedAlpha = 1;
    public float imageSelectedAlpha = 1;
    [Space]
    public float deselectedAlpha = 0;

    float backgroundPanelTargetAlpha;
    float textTargetAlpha;
    float imageTargetAlpha;

    [Space]
    public float changeSpeed;

    Image imageScript;

    private void Start()
    {
        imageScript = GetComponent<Image>();
        DeselectItem();
    }

    private void Update()
    {
        imageScript.color = LerpAlpha(imageScript.color, backgroundPanelTargetAlpha);

        foreach(Text textScript in GetComponentsInChildren<Text>())
        {
            textScript.color = LerpAlpha(textScript.color, textTargetAlpha);
        }
        foreach (Image image in GetComponentsInChildren<Image>())
        {
            image.color = LerpAlpha(image.color, imageTargetAlpha);
        }
    }

    Color LerpAlpha(Color startingCol,float targetValue)
    {
        Color tempCol = startingCol;
        //tempCol.a = Mathf.Lerp(tempCol.a, targetValue, changeSpeed * Time.deltaTime);
        tempCol.a = Mathf.MoveTowards(tempCol.a, targetValue, changeSpeed * Time.deltaTime);
        return tempCol;
    }

    public void SelectItem()
    {
        backgroundPanelTargetAlpha = backgroundPanelSelectedAlpha;
        textTargetAlpha = textSelectedAlpha;
        imageTargetAlpha = imageSelectedAlpha;
    }
    
    public void DeselectItem()
    {
        backgroundPanelTargetAlpha = deselectedAlpha;
        textTargetAlpha = deselectedAlpha;
        imageTargetAlpha = deselectedAlpha;
    }
}
