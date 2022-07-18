using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_220_Drive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = transform.position - transform.forward * 2;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + transform.forward * 2;
        }
    }
}
