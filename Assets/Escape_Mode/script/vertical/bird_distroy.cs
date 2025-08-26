using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_distroy : MonoBehaviour
{
    public GameObject obstcle;
    private void Update()
    {
        if(obstcle.transform.position.y<=-20)
        {
            Destroy(obstcle);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cut")
        {
            Destroy(gameObject);

            vibrat();

            GameObject.Find("playerlife").transform.GetComponent<lifecount>().loselife();
          

        }
    }
    
    public void vibrat()
    {
       // Handheld.Vibrate();
    vibrationControl.Vibrate(25);
    }
}
