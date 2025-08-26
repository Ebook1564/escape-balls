using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgSound : MonoBehaviour
{
    private static BgSound Music;
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
