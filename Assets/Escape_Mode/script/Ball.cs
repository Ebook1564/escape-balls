using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   // public GameObject ball;
    // Start is called before the first frame update
    
    void Update()
    {
        if (gameObject.transform.position.y <= -20)
        {
            Destroy(gameObject);
        }
    }
}
