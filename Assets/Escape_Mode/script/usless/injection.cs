using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class injection : MonoBehaviour
{
    public GameObject cutPrefab;
    public float cutlifeTime;
    private bool dragg;
    private Vector2 swipe;


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            dragg = true;
            swipe = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if(Input.GetMouseButtonUp(0)&& dragg)
        {
            dragg = false;
            spwancutter();
        }
    }
    void spwancutter()
    {
       Vector2 swipeEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject cutInstance = Instantiate(cutPrefab, swipe, Quaternion.identity);
        cutInstance.GetComponent<LineRenderer>().SetPosition(0, swipe);
        cutInstance.GetComponent<LineRenderer>().SetPosition(1, swipeEnd);

        Vector2[] colliderPoints = new Vector2[2];
        colliderPoints[0] = Vector2.zero;
        colliderPoints[1] = swipeEnd - swipe;
        cutInstance.GetComponent<EdgeCollider2D>().points = colliderPoints;
        Destroy(cutInstance, cutlifeTime);

    }
}
