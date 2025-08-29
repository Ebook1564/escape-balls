using UnityEngine;

public class ParallaxLooper : MonoBehaviour
{
    public float spriteWidth;            // Width of one background sprite
    public Transform cameraTransform;    // Reference to camera
    public float bufferZone = 2f;        // Extra buffer units (e.g., 2 sprite widths)
    private float cameraHalfWidth;

    private void Start()
    {
        if (cameraTransform == null)
            cameraTransform = Camera.main.transform;

        // Calculate real sprite width if unset
        if (spriteWidth == 0f)
        {
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            if (sr != null)
                spriteWidth = sr.bounds.size.x;
        }
        cameraHalfWidth = Camera.main.orthographicSize * Camera.main.aspect;
    }

    void Update()
    {
        float cameraLeftEdge = cameraTransform.position.x - cameraHalfWidth;
        float cameraRightEdge = cameraTransform.position.x + cameraHalfWidth;

        // Move segment forward if it's about to leave the extended buffer zone
        if (transform.position.x + spriteWidth / 2f < cameraLeftEdge - bufferZone * spriteWidth)
        {
            // Find how far ahead to move: total span of all segments
            transform.position += Vector3.right * spriteWidth * (5); // replace with total segment count
        }
        else if (transform.position.x - spriteWidth / 2f > cameraRightEdge + bufferZone * spriteWidth)
        {
            // Move segment back to left as needed
            transform.position -= Vector3.right * spriteWidth * (5);
        }
    }
}
