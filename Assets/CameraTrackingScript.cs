using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrackingScript : MonoBehaviour {

    public GameObject Target;

    public float moveStiffness = 0.5f;
    public float rotationStiffness = 0.5f;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Target.transform.position, moveStiffness * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, Target.transform.rotation, rotationStiffness * Time.deltaTime);
    }
}
