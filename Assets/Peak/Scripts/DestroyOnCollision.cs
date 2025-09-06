using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public GameObject obstcle;
    private void Update()
    {
        if (obstcle != null && obstcle.transform.position.y <= -20)
        {
            Destroy(obstcle);
            obstcle = null; // Optional: remove reference to avoid future access
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
