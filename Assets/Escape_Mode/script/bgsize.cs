using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgsize : MonoBehaviour
{
   
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.3f, 2.3f), /*Mathf.Clamp(transform.position.y, -4f, 4f)*/transform.position.y, transform.position.z);
    }
   
}
