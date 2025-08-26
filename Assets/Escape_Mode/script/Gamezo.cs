using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gamezo : MonoBehaviour
{
    public GameObject GamezoPannel;

    public void pannelOn()
    {
        GamezoPannel.SetActive(true);
    }
    public void pannelOff()
    {
        GamezoPannel.SetActive(false);
    }
    public void GamePlay()
    {
        Application.OpenURL("https://8170.play.gamezop.com/");
    }
    public void Dot()
    {
        SceneManager.LoadScene("MenuD");
    }
}
