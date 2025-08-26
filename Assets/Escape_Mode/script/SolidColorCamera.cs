using UnityEngine;

public class SolidColorCamera : MonoBehaviour
{
    public Color[] colors;          // Array of colors for background transitions
    public float duration = 5f;     // Duration of the color transition

    private Camera mainCamera;
    private float timeElapsed = 0f;
    private int colorIndex = 0;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
        mainCamera.backgroundColor = colors[0];
    }

    void Update()
    {
        // Increment the timer
        timeElapsed += Time.deltaTime;

        // Calculate the normalized progress (0 to 1) of the color transition
        float progress = Mathf.Clamp01(timeElapsed / duration);

        // Interpolate between current color and next color based on progress
        Color lerpedColor = Color.Lerp(colors[colorIndex], colors[(colorIndex + 1) % colors.Length], progress);

        // Set the camera's background color
        mainCamera.backgroundColor = lerpedColor;

        // Check if the transition to the next color is complete
        if (timeElapsed >= duration)
        {
            timeElapsed = 0f;
            colorIndex = (colorIndex + 1) % colors.Length;
        }
    }
}
