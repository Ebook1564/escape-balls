using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class progessbar : MonoBehaviour
{
    private Slider slider;
    private float targetProgress = 0;
    public float fillSpeed=0.1f;
    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        increment(1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
            slider.value += fillSpeed * Time.deltaTime;
    }
    public void increment(float newProgress)
    {
       targetProgress = slider.value + newProgress;
    }
}
