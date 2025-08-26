using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class infiniteManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject pausePannel;
    public GameObject spawner;
    // public GameObject gameover;
    public void resume()
    {
        Time.timeScale = 1;

        pausePannel.SetActive(false);
        spawner.SetActive(true);
       vertical_spawnwer.instance.spawnAgain();
        //  spawwner.instance.Start();
    }
    public void pause()
    {
       spawner.SetActive(false);
        pausePannel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("menu");
    }
    public void restart()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("Dark");

        //vertical_spawnwer.instance.spawnAgain();
        // spawwner.instance.Start();
    }

  
  
}
