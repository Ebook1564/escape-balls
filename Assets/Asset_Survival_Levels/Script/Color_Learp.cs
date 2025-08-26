using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Learp : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] [Range(0f, 1f)] float learptime;
    public  Color[] mycolors;
    int colorindex = 0;
    float t = 0f;
    int len;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        len = mycolors.Length;
    }
    private void Update()
    {
        spriteRenderer.material.color = Color.Lerp(spriteRenderer.material.color, mycolors[colorindex], learptime * Time.deltaTime);
        t = Mathf.Lerp(t, 1f, learptime * Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            colorindex++;
            colorindex = (colorindex >= len) ? 0 : colorindex;
        }

    }
}
