using UnityEngine;

public class PlayerIN : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;

    public float minX = -20f, maxX = 20f;
    public float minY = -5f, maxY = 7.5f;

    private float deltaX, deltaY;
    private Vector2 targetPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;        // top-down game, no gravity
        rb.freezeRotation = true;    // lock rotation
        targetPos = rb.position;
    }

    private void Update()
    {
        // --- Handle touch input ---
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
                    targetPos = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                    break;
            }
        }

        // --- Handle keyboard input ---
        float horizontal = 0f;

        if (Input.GetKey(KeyCode.LeftArrow)) horizontal = -1f;
        else if (Input.GetKey(KeyCode.RightArrow)) horizontal = 1f;

        if (horizontal != 0)
            targetPos = rb.position + new Vector2(horizontal * moveSpeed * Time.deltaTime, 0f);
    }

    private void FixedUpdate()
    {
        // --- Clamp position here ---
        targetPos.x = Mathf.Clamp(targetPos.x, minX, maxX);
        targetPos.y = Mathf.Clamp(targetPos.y, minY, maxY);

        // Move the Rigidbody
        rb.MovePosition(targetPos);
    }
}
