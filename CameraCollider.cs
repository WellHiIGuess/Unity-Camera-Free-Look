using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollider : MonoBehaviour
{
    public CameraFreeLook cameraFreeLook;

    float originalDistance;

    // Start is called before the first frame update
    void Start()
    {
        originalDistance = cameraFreeLook.distanceFromTarget;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(cameraFreeLook.target.position, (cameraFreeLook.camera.position - cameraFreeLook.target.position), out hit, Mathf.Infinity)) {
            if (!hit.transform.CompareTag("Tag") && !hit.transform.CompareTag("MainCamera")) {
                cameraFreeLook.distanceFromTarget = hit.distance;
                Debug.Log(hit.distance);
            }
        } else {
            cameraFreeLook.distanceFromTarget = originalDistance;
            Debug.Log("bean");
        }
    }
}
