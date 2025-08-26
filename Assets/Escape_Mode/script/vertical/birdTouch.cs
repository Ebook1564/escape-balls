using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdTouch : MonoBehaviour
{
   
    private void OnMouseDown()
    {
        if (gameObject.tag == "boomb")
        {
            GameObject.Find("playerlife").transform.GetComponent<lifecount>().loselife();
            GameObject.Find("playerlife").transform.GetComponent<lifecount>().loselife();
            GameObject.Find("playerlife").transform.GetComponent<lifecount>().loselife();

            Destroy(gameObject);
        }
    }
}
