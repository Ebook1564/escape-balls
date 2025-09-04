using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public float initialSpeed = 3f;  // Initial falling speed
    public float maxSpeed = 3f;     // Maximum speed
    public float acceleration = 0.1f;  // How quickly the speed increases

    private float currentSpeed;      // The current speed of the object

    void Start()
    {
        // Set the current speed to the initial speed when the object spawns
        currentSpeed = initialSpeed;
    }

    void Update()
    {
        // Increase the speed gradually over time
        currentSpeed += acceleration * Time.deltaTime;

        // Clamp the speed so it doesn't exceed the maximum speed
        currentSpeed = Mathf.Clamp(currentSpeed, initialSpeed, maxSpeed);

        // Move the object downward along the Y-axis
        transform.position += Vector3.down * currentSpeed * Time.deltaTime;
    }
}
