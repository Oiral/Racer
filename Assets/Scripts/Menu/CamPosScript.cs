using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CamPosScript : MonoBehaviour {

    public UnityEvent OnSelection;
    public UnityEvent OnHover;
    public UnityEvent LeaveHover;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawFrustum(Vector3.zero, Camera.main.fieldOfView, Camera.main.farClipPlane, Camera.main.nearClipPlane, Camera.main.aspect);
    }

}
