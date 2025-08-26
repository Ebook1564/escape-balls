using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutableobject : MonoBehaviour
{
  
    public bool harmful;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="cut")
        {
          
            Destroy(gameObject);
            if(!harmful)
            {
              
                GameObject.Find("score").transform.GetComponent<score>().NewScore += 1;
                
            }
          
        }
    }
}
