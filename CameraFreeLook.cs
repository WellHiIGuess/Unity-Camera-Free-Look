using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFreeLook : MonoBehaviour
{
    public Transform target;
    public Transform camera;

    public float angle = 0;
    public float angleUpDown = 0;
    public float distanceFromTarget = 1;
    public float maxUp;
    public float maxDown;

    // Update is called once per frame
    void Update()
    {
        if (angle >= 2 * Mathf.PI || angle <= -2 * Mathf.PI) {
            angle = 0;
        }

        if (angleUpDown >= maxUp) {
            angleUpDown = maxUp;
        } else if (angleUpDown <= maxDown) {
            angleUpDown = maxDown;
        }

        camera.position = new Vector3(target.position.x + Mathf.Cos(angle) * distanceFromTarget, target.position.y + angleUpDown, target.position.z + Mathf.Sin(angle) * distanceFromTarget);
        camera.LookAt(target);
    }
}
