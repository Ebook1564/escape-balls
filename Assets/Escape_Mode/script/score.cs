using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoretext;
    public int NewScore;

    void Start()
    {
        NewScore = 1;

    }
    public void Update()
    {
        scoretext.text = "Level: " +NewScore;
    }
    }
   
