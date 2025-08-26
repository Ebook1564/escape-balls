using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boombSound : MonoBehaviour
{
    public AudioSource bomb;
    // Start is called before the first frame update
    void Start()
    {
        bomb = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "boomb")
        {
            bomb.Play();
        }
    }
}
