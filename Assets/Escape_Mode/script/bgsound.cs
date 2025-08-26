using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgsound : MonoBehaviour
{
    private static bgsound Music;
    private void Awake()
    {
        if (Music == null)
        {
           Music = this;
            DontDestroyOnLoad(Music);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
