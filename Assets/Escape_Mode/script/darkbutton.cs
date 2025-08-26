using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class darkbutton : MonoBehaviour
{
    [SerializeField] GameObject soundonIcon;
    [SerializeField] GameObject soundoffIcon;
    private bool muted = false;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            load();
        }
        else
        {
            load();
        }
        updateButtonIcon();
       // AudioListener.pause = muted;
    }
    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
         //   AudioListener.pause = true;
        }
        else
        {
            muted = false;
           // AudioListener.pause = false;
        }
        save();
        updateButtonIcon();
    }
    private void updateButtonIcon()
    {
        if (muted == false)
        {
            soundonIcon.SetActive(true);
            soundoffIcon.SetActive(false);
        }
        else
        {
            soundoffIcon.SetActive(true);
            soundonIcon.SetActive(false);
        }
    }
    private void load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
