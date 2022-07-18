﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common_Transform_Movement : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position =  transform.position + Vector3.forward * speed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position =  transform.position + Vector3.forward * -speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position =  transform.position + Vector3.right * -speed;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position =  transform.position + Vector3.right * speed;
        }
    }
}
