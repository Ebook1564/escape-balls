using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class lifecount : MonoBehaviour
{
   // public static lifecount instance;
    public int numberOfLife;
    public Text scoreText;
    public GameObject lifePrefab;
    public GameObject gameover;
    public GameObject player;
    private List<GameObject> lives;
   public GameObject Levels;
    public GameObject ProgessBar;
    
    private void Start()
    {
       
        lives = new List<GameObject>();
        for(int i =0;i<numberOfLife; i++)
        {
            GameObject lifeInstance = Instantiate(lifePrefab, transform);
            lives.Add(lifeInstance);
            
        }
    }
    public void loselife()
    {
        numberOfLife--;

        GameObject lastlife = lives[lives.Count - 1];
        lives.Remove(lastlife);
        Destroy(lastlife);

        if (numberOfLife<=0)
        {
            int score = GameObject.Find("scoreText").GetComponent<score>().NewScore;
         
            scoreText.text = "Score " + scoreText.ToString();


        }
        
    }
    public void restart()
    {

        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }

    private void Update()
    {
        if(numberOfLife<=0)
        {
            Levels.SetActive(false);
            ProgessBar.SetActive(false);
            gameover.SetActive(true);
            player.SetActive(false);
          //  Time.timeScale = 0;
        }
      
    }
 
}
