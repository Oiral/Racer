using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CamPosScript : MonoBehaviour {

    public UnityEvent OnSelection;

	public void SelectPosition()
    {
        OnSelection.Invoke();
    }
}
