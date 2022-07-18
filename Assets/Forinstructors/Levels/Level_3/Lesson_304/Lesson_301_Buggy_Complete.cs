using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_301_Buggy_Complete : MonoBehaviour
{
    public float carSpeed = 100;
    public float acceleration = 0.5f;
    public float pitchIncrease = 0.04f;
    public float horizontalAcceleration = 5;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * Time.deltaTime * carSpeed;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            carSpeed = carSpeed + acceleration;
            audio.pitch =  audio.pitch + pitchIncrease;
            
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            carSpeed = carSpeed - acceleration;
            audio.pitch =  audio.pitch - pitchIncrease;
        }

        if(Input.GetKey(KeyCode.RightArrow) && transform.position.x < 7.5f)
        {
           transform.position = transform.position + transform.right * Time.deltaTime * horizontalAcceleration;
        }

        if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -7.5f)
        {
         transform.position = transform.position - transform.right * Time.deltaTime * horizontalAcceleration;
            
        }
    }
}
