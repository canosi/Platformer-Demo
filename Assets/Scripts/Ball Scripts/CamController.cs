using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public GameObject player;

   
    void Start()
    {
        
    }


    void Update()
    {   
        
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}
