using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProLevel_selector : MonoBehaviour
{

    public Button[] Buttons;

    // Start is called before the first frame update
    void Start()
    {
        int levelPAt = PlayerPrefs.GetInt("levelPAt", 2);

        for (int i = 0; i < Buttons.Length; i++)
        {
            if (i + 2 > levelPAt)
                Buttons[i].interactable = false;
        }
    }
}
