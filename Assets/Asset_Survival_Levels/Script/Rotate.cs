using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    
    public float Speed;
    void Update()
    {
        gameObject.transform.Rotate(0, 0, Speed);
    }
}
