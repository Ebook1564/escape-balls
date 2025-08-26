using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dark : MonoBehaviour
{
    public GameObject darkpannel;
   
    public void ondarkpannel()
    {
        darkpannel.SetActive(true);
    }
    public void closedarkpannel()
    {
        darkpannel.SetActive(false);
    }
}
