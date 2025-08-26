using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{

    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float life;
    private void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(Random.Range(minX,maxX),Random.Range(minY,maxY));
        Destroy(gameObject, life);
    }
}
