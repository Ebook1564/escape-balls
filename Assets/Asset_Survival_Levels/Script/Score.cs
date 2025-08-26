using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
   
   
    public Text scoretext;
    float NewScore;
    
    private void Update()
    {
        if(player.position.y>0)
       NewScore = (player.position.y);

        scoretext.text = " " + (int)NewScore;


        if (PlayerPrefs.GetInt("BestScore") < NewScore)
        {
            PlayerPrefs.SetInt("BestScore", (int)NewScore);
        }
    }
}
