using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bestScore : MonoBehaviour
{
    public Text BestScoreText;
    void Start()
    {
        BestScoreText.text = "HighScore: " + PlayerPrefs.GetInt("BestScore");
    }
}
