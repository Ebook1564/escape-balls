using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistroyInstruction : MonoBehaviour
{
  
    public GameObject instruction;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
      if(player.transform.position.y >= 0.5 || player.transform.position.y <= -0.5 || player.transform.position.x>= 0.5 || player.transform.position.x <= -0.5)
        {
            instruction.SetActive(false);
        }
    }
}
