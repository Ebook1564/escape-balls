using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Best : MonoBehaviour
{
    public Text BestScoreText;
    void Start()
    {
        BestScoreText.text = " " + PlayerPrefs.GetInt("BestScore");
    }
}
