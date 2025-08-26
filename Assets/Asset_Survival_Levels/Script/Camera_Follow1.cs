using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow1 : MonoBehaviour
{
    private Transform PlayerTransform;
    public Vector3 offset;
    public float smoothTime = 0.3f;
    private Vector3 velocity;

    void Start()
    {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void LateUpdate()
    {
        Vector3 temp = transform.position;
        temp.y = PlayerTransform.position.y + 2.5f;
        transform.position = temp;
        transform.position = Vector3.SmoothDamp(transform.position, temp, ref velocity, smoothTime);
    }
}
