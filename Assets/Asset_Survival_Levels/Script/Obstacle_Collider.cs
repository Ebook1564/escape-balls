using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Collider : MonoBehaviour
{
    public GameObject Restart_Pannel;
    public GameObject Splash;
    public GameObject ProgessBar;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag=="Obstacle")
        {
            ProgessBar.SetActive(false);
            Instantiate(Splash, transform.position, Quaternion.identity);
            new WaitForSeconds(2);
            Restart_Pannel.SetActive(true);
          Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
    
}
