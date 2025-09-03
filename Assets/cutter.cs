using UnityEngine;

public class CutterMotionWithParentFollow : MonoBehaviour
{
    public float rotationSpeed = 180f; // degrees per second
    public float moveFrequency = 1f;   // cycles per second

    private Transform parentTransform;
    private float minY;
    private float maxY;
    private float amplitude;

    void Start()
    {
        parentTransform = transform.parent;
        SpriteRenderer parentRenderer = parentTransform.GetComponent<SpriteRenderer>();

        if (parentRenderer != null)
        {
            float parentHalfHeight = parentRenderer.bounds.size.y / 2f;
            minY = -parentHalfHeight;
            maxY = parentHalfHeight;
            amplitude = (maxY - minY) / 2f * 0.9f;
        }
        else
        {
            minY = -1f;
            maxY = 1f;
            amplitude = 0.9f;
        }
    }

    void Update()
    {
        // Rotate on Z axis
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);

        // Oscillate up and down based on the parent’s current Y position
        float centerY = parentTransform.position.y;
        float yOffset = Mathf.Sin(Time.time * moveFrequency * Mathf.PI * 2) * amplitude;
        float newY = Mathf.Clamp(centerY + yOffset, centerY + minY, centerY + maxY);

        Vector3 pos = transform.position;
        pos.y = newY;
        transform.position = pos;
    }
}
