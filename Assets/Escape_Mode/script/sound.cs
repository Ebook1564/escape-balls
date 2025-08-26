using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource tick;
  
    void Start()
    {
        tick = GetComponent<AudioSource>();
      
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "boomb")
        {
           // tick.Play();
        }
       
    }
}
