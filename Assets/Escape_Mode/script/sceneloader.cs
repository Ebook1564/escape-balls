using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneloader : MonoBehaviour
{

    public void sceneChangr(string name)
    {
        SceneManager.LoadScene(name);
    }

   

}
