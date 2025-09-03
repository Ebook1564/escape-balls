using UnityEngine;

[ExecuteAlways]
public class ScaleToCamera : MonoBehaviour
{
    [Tooltip("Assign the Camera whose viewport this object should match.")]
    public Camera targetCamera;

    void LateUpdate()
    {
        if (targetCamera == null || !targetCamera.orthographic) return;

        // Step 1: Camera world size
        float worldHeight = targetCamera.orthographicSize * 2f;
        float worldWidth = worldHeight * targetCamera.aspect;

        // Step 2: Get object's unscaled size
        Renderer rend = GetComponentInChildren<Renderer>();
        if (rend == null) return;

        // Temporarily reset scale to 1 to get true base size
        Vector3 originalScale = transform.localScale;
        transform.localScale = Vector3.one;
        Vector3 objSize = rend.bounds.size;
        transform.localScale = originalScale;

        // Step 3: Compute scale factors
        float scaleX = worldWidth / objSize.x;
        float scaleY = worldHeight / objSize.y;

        // Step 4: Pick the smaller one to preserve aspect ratio
        float finalScale = Mathf.Min(scaleX, scaleY);

        // Step 5: Apply uniform scale
        transform.localScale = new Vector3(finalScale, finalScale, 1f);
    }
}
