using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject pausePannel;
   

    public void resume()
    {
        Time.timeScale = 1;
       
        pausePannel.SetActive(false);
      
    }
    public void pause()
    {
    
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
        SceneManager.LoadScene("game");

    }
    
    public void nextselect1()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene("Level_Selector2");

    }
    public void nextselect2()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene("Level_next");

    }
    
    public void L1()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene("Level_1");

        
    }
    public void unlock2()
    {


        if (3 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 3);
        }

    }
    public void unlock3()
    {


        if (4 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 4);
        }

    }
    public void unlock4()
    {


        if (5 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 5);
        }

    } 
    public void unlock5()
    {


        if (6 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 6);
        }

    }
    public void unlock6()
    {


        if (7 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 7);
        }

    }
    public void unlock7()
    {


        if (8 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 8);
        }

    }
    public void unlock8()
    {


        if (9 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 9);
        }

    }
    public void unlock9()
    {


        if (10 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 10);
        }

    }
    public void unlock10()
    {


        if (11 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 11);
        }

    }
    public void L2()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene(2);

        if (3 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 3);
        }

    }
    public void L3()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
        if (4 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 4);
        }
    }
    public void L4()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
        if (5 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 5);
        }
    } 
    public void L5()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
        if (6 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 6);
        }
    }
     public void L6()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene(6);
        if (7 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 7);
        }
    }
     public void L7()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene(7);
        if (8 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 8);
        }
    } 
    public void L8()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene(8);
        if (9 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 9);
        }
    } 
    public void L9()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene(9);
        if (10 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 10);
        }
    } 
    

    public void L10()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene(10);
        if (11 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 11);
        }
    } 
    public void Levelselect2()
    {
       
        Time.timeScale = 1;
        SceneManager.LoadScene("Level_Selector3");
        
    }






    public void unlockP2()
    {


        if (3 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 3);
        }

    }
    public void unlockP3()
    {


        if (4 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 4);
        }

    }
    public void unlockP4()
    {


        if (5 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 5);
        }

    }
    public void unlockP5()
    {


        if (6 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 6);
        }

    }
    public void unlockP6()
    {


        if (7 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 7);
        }

    }
    public void unlockP7()
    {


        if (8 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 8);
        }

    }
    public void unlockP8()
    {


        if (9 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 9);
        }

    }
    public void unlockP9()
    {


        if (10 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 10);
        }

    }
    public void unlockP10()
    {


        if (11 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 11);
        }

    }
    public void LP1()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("Level_P1");

        if (2 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 2);
        }

    }
    public void LP2()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("Level_P2");
        if (3 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 3);
        }
    }
    public void LP3()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("Level_P3");
        if (4 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 4);
        }
    }
    public void LP4()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("Level_P4");
        if (5 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 5);
        }
    }
    public void LP5()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("Level_P5");
        if (6 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 6);
        }
    }
    public void LP6()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("Level_P6");
        if (7 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt",7);
        }
    }
    public void LP7()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("Level_P7");
        if (8 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 8);
        }
    }
    public void LP8()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("Level_P8");
        if (9> PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt",9);
        }
    }


    public void LP9()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("Level_P9");
        if (10 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 10);
        }
    }
     public void LP10()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene("Level_P10");
        if (11 > PlayerPrefs.GetInt("levelPAt"))
        {
            PlayerPrefs.SetInt("levelPAt", 11);
        }
    }


}
