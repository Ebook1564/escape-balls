using UnityEngine;

public class RotatorAndMover2D : MonoBehaviour
{
    public float rotationSpeed = 180f;        // Degrees per second
    public enum Axis { X, Y }
    public Axis moveAxis = Axis.X;            // Selectable in Inspector

    [Header("Movement Settings")]
    public float moveFrequency = 1f;          // Cycles per second
    public float moveAmplitude = 1f;          // Distance to move from center
    public float minLimit = -2f;              // World minimum position
    public float maxLimit = 2f;               // World maximum position

    private float baseX, baseY;

    void Start()
    {
        baseX = transform.position.x;
        baseY = transform.position.y;
    }

    void Update()
    {
        // Rotate on Z axis (for 2D games)
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);

        // Move along chosen world axis
        Vector3 pos = transform.position;
        float offset = Mathf.Sin(Time.time * moveFrequency * Mathf.PI * 2) * moveAmplitude;

        if (moveAxis == Axis.X)
        {
            pos.x = Mathf.Clamp(baseX + offset, minLimit, maxLimit);
        }
        else
        {
            pos.y = Mathf.Clamp(baseY + offset, minLimit, maxLimit);
        }

        transform.position = pos;
    }
}
