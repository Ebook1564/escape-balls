using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject ProgessBar;
    public GameObject Finish_Pannel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player");
        {
            ProgessBar.SetActive(false);
            Finish_Pannel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
