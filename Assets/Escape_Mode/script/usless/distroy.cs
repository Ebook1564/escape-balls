using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distroy : MonoBehaviour
{
    public GameObject level;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cut")
        {
            level.SetActive(true);
        }
    }
}
