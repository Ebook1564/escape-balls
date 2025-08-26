using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class levelprogress : MonoBehaviour
{
    [SerializeField] GameObject playerGO;
    [SerializeField] GameObject Finish;
    Image progessbar;
    float maxdistance;
    private void Start()
    {
        progessbar = GetComponent<Image>();
        maxdistance = Finish.transform.position.y;
        progessbar.fillAmount = playerGO.transform.position.y / maxdistance;
    }
    private void Update()
    {
        if (progessbar.fillAmount < 1)
        {
            progessbar.fillAmount = playerGO.transform.position.y / maxdistance;
        }
    }
}
