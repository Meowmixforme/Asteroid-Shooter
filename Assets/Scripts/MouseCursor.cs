using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{

    public float movementDamping = 0.2f;
    public float distanceFromCamera = 7.5f;
    public float offset = 3.5f;
    public float lookTargetDistance = 2.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        mousePosition.z = distanceFromCamera;

        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        targetPosition.z -= offset;

        transform.position = Vector3.Lerp(transform.position, targetPosition, movementDamping);

        Vector3 lookTarget = targetPosition;
        lookTarget.z += lookTargetDistance;
        transform.LookAt(lookTarget);
    }


}
