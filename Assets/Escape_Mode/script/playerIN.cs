using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerIN : MonoBehaviour
{
    public Rigidbody2D rb;

    private float deltaX, deltaY;
    public float moveSpeed = 5f; // Speed for keyboard movement

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Clamp position to stay within bounds
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -5f, 5f),
            Mathf.Clamp(transform.position.y, -5f, 7.5f),
            transform.position.z
        );

        // Handle touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    deltaX = touchPos.x - transform.position.x;
                    deltaY = touchPos.y - transform.position.y;
                    break;
                case TouchPhase.Moved:
                    rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY) * 1.2f);
                    break;
                case TouchPhase.Ended:
                    rb.linearVelocity = Vector2.zero;
                    break;
            }
        }

        // Handle keyboard input
        float horizontal = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontal = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontal = 1f;
        }

        if (horizontal != 0)
        {
            rb.linearVelocity = new Vector2(horizontal * moveSpeed, rb.linearVelocity.y);
        }
        else
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }
    }
}
