using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelSever : MonoBehaviour
{
    public Text scoretext;
    float Score;
    private void Update()
    {
        Score += 2 * Time.deltaTime;

        scoretext.text = "Score: " + (int)Score;


        if (PlayerPrefs.GetInt("BestScore") < Score)
        {
            PlayerPrefs.SetInt("BestScore", (int)Score);
        }
    }
}
