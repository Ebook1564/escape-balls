using UnityEngine;
using System.Collections.Generic;

[ExecuteAlways]
public class CameraViewportManager : MonoBehaviour
{
    [Tooltip("Assign the Base Camera here. If empty, will use Camera.main.")]
    public Camera baseCamera;

    [Tooltip("Any extra cameras (non-overlay) to also apply the viewport to.")]
    public List<Camera> extraCameras = new List<Camera>();

    [Header("Viewport Options")]
    public bool useCustomArea = false;

    [Tooltip("Custom viewport area (x,y,width,height). Normalized 0–1.")]
    public Rect customViewport = new Rect(0.25f, 0.25f, 0.5f, 0.5f);

    private Vector2 lastScreenSize;

    void OnEnable()
    {
        if (baseCamera == null)
            baseCamera = Camera.main;

        ApplyViewport();
    }

    void Update()
    {
        // Detect screen/orientation change
        if (Screen.width != (int)lastScreenSize.x || Screen.height != (int)lastScreenSize.y)
        {
            lastScreenSize = new Vector2(Screen.width, Screen.height);
            ApplyViewport();
        }
    }

    void ApplyViewport()
    {
        if (baseCamera == null)
        {
            Debug.LogWarning("No Base Camera assigned.");
            return;
        }

        Rect rect;

        if (useCustomArea)
            rect = customViewport; // Example: centered box
        else
            rect = new Rect(0f, 0f, 1f, 1f); // Fullscreen

        // Apply to base camera
        baseCamera.rect = rect;
        Debug.Log($"Base Camera '{baseCamera.name}' viewport set to {rect}");

        // Apply to extra cameras (non-overlay only)
        foreach (Camera cam in extraCameras)
        {
            if (cam != null && cam != baseCamera)
                cam.rect = rect;
        }
    }
}
