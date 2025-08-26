using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager2 : MonoBehaviour
{
    public GameObject Pause_pannel;
  public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level_1");
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void Pause()
    {
        Time.timeScale = 0;
        Pause_pannel.SetActive(true);
    } 
    public void Infinite()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Infinite");
    }
    public void Level2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level_1");
    } 
    public void Level3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level_1");
    } 
    public void Level6()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level_1");
    }
    public void Resume()
    {
        Time.timeScale = 1;
        Pause_pannel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void RateUs()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.HyperAppsVP.DotClassicGame");
    }
    public void MoreGame()
    {
        Application.OpenURL("https://8170.play.gamezop.com/");
    }
}
