using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawwner : MonoBehaviour
{
    public static spawwner instance;
    [Header("target")]
    public GameObject prefabs;
    
    public float interval;
    public float minX;
    public float maxX;
    public float y;
    [Header("visual")]
    public Sprite[] sprites;


    public void Start()
    {
        InvokeRepeating("spawn", interval, interval);
    }
    void spawn()
    {
        GameObject instance = Instantiate(prefabs);
        instance.transform.position = new Vector2(Random.Range(minX, maxX), y);
        instance.transform.SetParent(transform);
        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        instance.GetComponent<SpriteRenderer>().sprite = randomSprite;
    }
}
