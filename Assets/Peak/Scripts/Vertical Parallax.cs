using UnityEngine;

public class VerticalParallax : MonoBehaviour
{
    [System.Serializable]
    public class ParallaxLayer
    {
        public Transform layerTransform;
        public float speed; // Speed at which this layer moves downwards
    }

    public ParallaxLayer[] layers;

    void Update()
    {
        foreach (var layer in layers)
        {
            if (layer.layerTransform != null)
            {
                // Move the layer downward based on its speed and elapsed time
                layer.layerTransform.position += Vector3.down * layer.speed * Time.deltaTime;
            }
        }
    }
}
