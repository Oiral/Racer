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
            Quaternion zOnlyRot = Quaternion.Euler(new Vector3(transform.position.x, transform.position.y,Target.transform.rotation.eulerAngles.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, zOnlyRot, zRotStiffness * Time.deltaTime);
            Quaternion xOnlyRot = Quaternion.Euler(new Vector3(Target.transform.rotation.eulerAngles.x, transform.position.y, transform.position.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, xOnlyRot, xRotStiffness * Time.deltaTime);
            Quaternion yOnlyRot = Quaternion.Euler(new Vector3(transform.position.x, Target.transform.rotation.eulerAngles.y, transform.position.z));
            transform.rotation = Quaternion.Lerp(transform.rotation, yOnlyRot, yRotStiffness * Time.deltaTime);
            /*
            Vector3 currRotEuler = transform.rotation.eulerAngles;
            Vector3 targetRotEuler = Target.transform.rotation.eulerAngles;

            float xRot = Mathf.Lerp(currRotEuler.x, targetRotEuler.x, xRotStiffness * Time.deltaTime);
            float yRot = Mathf.Lerp(currRotEuler.y, targetRotEuler.y, yRotStiffness * Time.deltaTime);
            float zRot = Mathf.Lerp(currRotEuler.z, targetRotEuler.z, zRotStiffness * Time.deltaTime);

            xRot = ((xRot - 180) % 360) + 180;
            yRot = ((yRot - 180) % 360) + 180;
            zRot = ((zRot - 180) % 360) + 180;

            currRotEuler = new Vector3(xRot, yRot, zRot);

            transform.rotation = Quaternion.Euler(currRotEuler);
            */
        }
    }
}
