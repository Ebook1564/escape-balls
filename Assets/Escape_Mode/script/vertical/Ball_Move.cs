using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{
    public float initialSpeed = 5f;  // Initial falling speed
    public float maxSpeed = 6f;     // Maximum speed
    public float acceleration = 0.1f;  // How quickly the speed increases

    private float currentSpeed;      // The current speed of the object
    private bool isDragging = false; // To check if the ball is being dragged

    void Start()
    {
        // Set the current speed to the initial speed when the object spawns
        currentSpeed = initialSpeed;
    }

    void Update()
    {
        HandleMovement();
        HandleTouchInput();
    }

    private void HandleMovement()
    {
        // If the ball is not being dragged, continue moving upward
        if (!isDragging)
        {
            // Increase the speed gradually over time
            currentSpeed += acceleration * Time.deltaTime;

            // Clamp the speed so it doesn't exceed the maximum speed
            currentSpeed = Mathf.Clamp(currentSpeed, initialSpeed, maxSpeed);

            // Move the object upward along the Y-axis
            transform.position += Vector3.up * currentSpeed * Time.deltaTime;
        }
    }

    private void HandleTouchInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Convert the touch position to world space
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, Camera.main.nearClipPlane));
            touchPosition.z = 0; // Ensure the z position is zero since we are in 2D space

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Check if the touch started on the ball
                    if (IsTouchOnBall(touchPosition))
                    {
                        isDragging = true;
                    }
                    break;

                case TouchPhase.Moved:
                    // If dragging, update the ball position to follow the touch
                    if (isDragging)
                    {
                        transform.position = new Vector3(touchPosition.x, transform.position.y, 0);
                    }
                    break;

                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    // Stop dragging when the touch is released
                    isDragging = false;
                    break;
            }
        }
    }

    private bool IsTouchOnBall(Vector3 touchPosition)
    {
        // Check if the touch position is within the bounds of the ball
        Collider2D collider = GetComponent<Collider2D>();
        return collider != null && collider.OverlapPoint(touchPosition);
    }
}
