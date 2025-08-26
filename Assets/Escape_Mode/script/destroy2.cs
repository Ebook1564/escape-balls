using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="boomb")
        {
            GameObject.Find("playerlife").transform.GetComponent<lifecount>().loselife();
            Destroy(collision.gameObject);
            // GameObject.Find("playerlife").transform.GetComponent<lifecount>().loselife();
        }

       
    }
}

