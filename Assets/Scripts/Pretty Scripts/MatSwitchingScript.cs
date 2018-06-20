using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatSwitchingScript : MonoBehaviour {

    public SkinnedMeshRenderer skinnedRenderer;
    public float swapTime = 0.5f;
    public bool swapping = true;

    public List<Material> swappingMats;
    private int curMat;

	// Use this for initialization
	void Start () {
        curMat = 0;
        //SwapMat();
        StartCoroutine(RunSwapping());
	}

    IEnumerator RunSwapping()
    {
        while (swapping)
        {
            yield return new WaitForSeconds(swapTime);
            SwapMat();
        }
    }
	
    void SwapMat()
    {
        curMat += 1;
        if (curMat >= swappingMats.Count)
        {
            curMat = 0;
        }
        Debug.Log(curMat);

        Material[] mats = skinnedRenderer.materials;

        mats[1] = swappingMats[curMat];
        skinnedRenderer.materials = mats;
    }

}
