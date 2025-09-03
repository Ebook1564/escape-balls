using UnityEngine;

public class PendulumOscillator : MonoBehaviour
{
    [Header("Obstacle References")]
    public Transform pivotObstacle;     // The static obstacle (pivot)
    public Transform swingingObstacle;  // The swinging obstacle

    [Header("Pendulum Settings")]
    public float maxAngle = 45f;        // Maximum swing angle
    public float acceleration = 1f;     // How strong the swing feels
    public float startAngle = 30f;      // Initial tilt

    public float currentAngle;
    public float angularVelocity = .2f;

    void Start()
    {
        currentAngle = startAngle;

        if (pivotObstacle == null || swingingObstacle == null)
        {
            Debug.LogError("PendulumOscillator: Please assign both PivotObstacle (static) and SwingingObstacle (moving).");
            enabled = false;
        }
    }

    void Update()
    {
        // Pendulum restoring force
        float gravityEffect = -Mathf.Sin(currentAngle * Mathf.Deg2Rad) * acceleration * Time.deltaTime;
        angularVelocity += gravityEffect;
        currentAngle += angularVelocity;

        // Clamp swing range
        if (currentAngle > maxAngle)
        {
            currentAngle = maxAngle;
            angularVelocity *= -1;
        }
        else if (currentAngle < -maxAngle)
        {
            currentAngle = -maxAngle;
            angularVelocity *= -1;
        }

        // Rotate the swinging obstacle around the pivot obstacle
        swingingObstacle.position = pivotObstacle.position;
        swingingObstacle.rotation = Quaternion.Euler(0, 0, currentAngle);
    }
}
