using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical_spawnwer : MonoBehaviour
{
    public GameObject[] obstacles;
    public static vertical_spawnwer instance;
    public void Start()
    {
        if (instance == null)
            instance = this;
        StartCoroutine(Spawnitem(1f));
    }
    IEnumerator Spawnitem(float time)
    {
        yield return new WaitForSecondsRealtime(time * 2);
        Vector2 pos = new Vector2(Random.Range(0, 1), transform.position.y);
        Instantiate(obstacles[Random.Range(0, obstacles.Length)], pos, Quaternion.identity);
        StartCoroutine(Spawnitem(Random.Range(19f, 19f)));
    }
    public void spawnAgain()
    {
        StartCoroutine(Spawnitem(Random.Range(2.5f, 2.5f)));
    }
}
