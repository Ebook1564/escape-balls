using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge_Levels : MonoBehaviour
{
    public float Speed;
    public float MaxSpeed;

    public float UpSpeed;
    public float MaxUpSpeed;
    public GameObject Mainplayer;

    private Rigidbody2D Character;
    private float Screenwidth;
  
    private void Start()
    {
        Screenwidth = Screen.width;
        Character = Mainplayer.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {

    }
    private void FixedUpdate()
    {
        if (MaxUpSpeed > UpSpeed)
        {
            UpSpeed = UpSpeed + 0.01f * Time.deltaTime;
        }
        transform.position = transform.position + new Vector3(0, UpSpeed * Time.fixedDeltaTime, 0);

        if (MaxSpeed > Speed)
        {
            Speed = Speed + 0.01f * Time.deltaTime;
        }
        int i = 0;
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > Screenwidth / 2)
            {
                Run(1.0f);

            }
            if (Input.GetTouch(i).position.x < Screenwidth / 2)
            {
                Run(-1.0f);

            }
            i++;
        }
    }

    void Run(float horizontalInput)
    {

        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
    }
}
