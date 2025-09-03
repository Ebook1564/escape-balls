using UnityEngine;
using System.Collections.Generic;

public class VerticalParallax : MonoBehaviour
{
    [System.Serializable]
    public class ParallaxLayer
    {
        public Transform layerTransform;
        public float speed; // Speed at which this layer moves downwards
    }

    [System.Serializable]
    public class LockedGroup
    {
        public string groupName = "Locked Group";
        public ParallaxLayer[] layers;
        [HideInInspector] public float[] initialYOffsets; // Stores relative Y positions within group
    }

    [Header("Locked Groups")]
    public LockedGroup[] lockedGroups;

    [Header("Normal Parallax Layers")]
    public ParallaxLayer[] parallaxLayers;

    void Start()
    {
        // Initialize all locked groups
        foreach (var group in lockedGroups)
        {
            if (group.layers.Length > 1 && group.layers[0].layerTransform != null)
            {
                // Store initial relative Y positions within this group
                group.initialYOffsets = new float[group.layers.Length];
                Vector3 basePosition = group.layers[0].layerTransform.position;

                for (int i = 0; i < group.layers.Length; i++)
                {
                    if (group.layers[i].layerTransform != null)
                    {
                        group.initialYOffsets[i] = group.layers[i].layerTransform.position.y - basePosition.y;
                    }
                }
            }
        }
    }

    void Update()
    {
        // --- Handle all locked groups ---
        foreach (var group in lockedGroups)
        {
            if (group.layers.Length == 0) continue;

            // Move the base layer (first layer in group)
            if (group.layers[0].layerTransform != null)
            {
                group.layers[0].layerTransform.position += Vector3.down * group.layers[0].speed * Time.deltaTime;
            }

            // Move and maintain relative positions for all other layers in the group
            for (int i = 1; i < group.layers.Length; i++)
            {
                if (group.layers[i].layerTransform != null && group.layers[0].layerTransform != null)
                {
                    // Move the layer based on its own speed
                    group.layers[i].layerTransform.position += Vector3.down * group.layers[i].speed * Time.deltaTime;

                    // Maintain the correct relative position to the base layer
                    group.layers[i].layerTransform.position = new Vector3(
                        group.layers[i].layerTransform.position.x,
                        group.layers[0].layerTransform.position.y + group.initialYOffsets[i],
                        group.layers[i].layerTransform.position.z
                    );
                }
            }
        }

        // --- Handle normal parallax layers as usual ---
        foreach (var layer in parallaxLayers)
        {
            if (layer.layerTransform != null)
            {
                layer.layerTransform.position += Vector3.down * layer.speed * Time.deltaTime;
            }
        }
    }

    // Optional: Helper method to add a new locked group
    public void AddLockedGroup()
    {
        List<LockedGroup> groupsList = new List<LockedGroup>(lockedGroups);
        groupsList.Add(new LockedGroup());
        lockedGroups = groupsList.ToArray();
    }

    // Optional: Helper method to remove a locked group
    public void RemoveLockedGroup(int index)
    {
        if (index >= 0 && index < lockedGroups.Length)
        {
            List<LockedGroup> groupsList = new List<LockedGroup>(lockedGroups);
            groupsList.RemoveAt(index);
            lockedGroups = groupsList.ToArray();
        }
    }
}
