using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public enum MoveAxis { None, X, Y }
    [Header("Movement Settings")]
    public MoveAxis moveAxis = MoveAxis.None;  // Choose movement type

    // X movement range
    public float minX;
    public float maxX;

    // Y movement range
    public float minY;
    public float maxY;

    public float moveFrequency = 1f;  // Speed of back-and-forth motion
    public int moveCycles = -1;       // -1 = infinite, or set how many cycles

    [Header("Rotation Settings")]
    public bool enableRotation = false;
    public float angularSpeed = 90f;  // Degrees per second

    private Vector3 startPos;
    private float moveTimer = 0f;
    private int completedCycles = 0;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Handle movement
        if (moveAxis != MoveAxis.None && (moveCycles < 0 || completedCycles < moveCycles))
        {
            moveTimer += Time.deltaTime * moveFrequency;

            if (moveAxis == MoveAxis.X)
            {
                float t = (Mathf.Sin(moveTimer * Mathf.PI * 2f) + 1f) / 2f; // ping-pong effect
                float newX = Mathf.Lerp(minX, maxX, t);
                transform.position = new Vector3(newX, startPos.y, startPos.z);
            }
            else if (moveAxis == MoveAxis.Y)
            {
                float t = (Mathf.Sin(moveTimer * Mathf.PI * 2f) + 1f) / 2f;
                float newY = Mathf.Lerp(minY, maxY, t);
                transform.position = new Vector3(startPos.x, newY, startPos.z);
            }

            // Count cycles (each full sine wave is 1 cycle)
            if (moveTimer >= 1f)
            {
                moveTimer -= 1f;
                completedCycles++;
            }
        }

        // Handle rotation
        if (enableRotation)
        {
            transform.Rotate(Vector3.forward, angularSpeed * Time.deltaTime);
        }
    }
}
