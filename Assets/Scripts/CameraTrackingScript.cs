using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrackingScript : MonoBehaviour {

    public GameObject Target;

    public float moveStiffness = 0.5f;
    public float rotationStiffness = 0.5f;

    
    public bool rotationLinked = true;
    [Header("UnLinked Rotation")]
    public float xRotStiffness = 10;
    public float yRotStiffness = 10;
    public float zRotStiffness = 10;


    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, Target.transform.position, moveStiffness * Time.deltaTime);

        if (rotationLinked)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Target.transform.rotation, rotationStiffness * Time.deltaTime);
        }
        else
        {
            /*
            Quaternion zOnlyRot = Quaternion.Euler(new Vector3(transform.position.x, transform.position.y,Target.transform.rotation.eulerAngles.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, zOnlyRot, zRotStiffness * Time.deltaTime);
            Quaternion xOnlyRot = Quaternion.Euler(new Vector3(Target.transform.rotation.eulerAngles.x, transform.position.y, transform.position.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, xOnlyRot, xRotStiffness * Time.deltaTime);
            Quaternion yOnlyRot = Quaternion.Euler(new Vector3(transform.position.x, Target.transform.rotation.eulerAngles.y, transform.position.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, yOnlyRot, yRotStiffness * Time.deltaTime);
            */
            
            Vector3 currRotEuler = transform.rotation.eulerAngles;
            Vector3 targetRotEuler = Target.transform.rotation.eulerAngles;

            float xRot = Mathf.LerpAngle(currRotEuler.x, targetRotEuler.x, xRotStiffness * Time.deltaTime);
            float yRot = Mathf.LerpAngle(currRotEuler.y, targetRotEuler.y, yRotStiffness * Time.deltaTime);
            float zRot = Mathf.LerpAngle(currRotEuler.z, targetRotEuler.z, zRotStiffness * Time.deltaTime);

            currRotEuler = new Vector3(xRot, yRot, zRot);

            transform.rotation = Quaternion.Euler(currRotEuler);
            
        }
    }
}
