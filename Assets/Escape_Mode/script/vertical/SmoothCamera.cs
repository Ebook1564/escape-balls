using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public Transform target; // The object that the camera will follow (e.g., the player)
    public float smoothSpeed = 0.125f; // How smoothly the camera follows the target
    public Vector3 offset; // Offset from the target object

    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        if (target == null)
            return; // If there's no target, do nothing

        // Desired position based on target position and offset
        Vector3 desiredPosition = target.position + offset;

        // Smoothly move the camera towards the desired position
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);

        // Update the camera position
        transform.position = smoothedPosition;
    }
}
