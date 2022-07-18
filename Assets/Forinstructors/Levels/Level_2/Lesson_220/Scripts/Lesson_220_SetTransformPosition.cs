using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_220_SetTransformPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(21, 1, 6);
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            transform.position = new Vector3(11, 3, 5);
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            transform.position = new Vector3(29, 1, 21);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(3, 1, 18);
        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector3(-2, 0, 10);
        } 
        else if(Input.GetKeyDown(KeyCode.F))
        {
            transform.position = new Vector3(15, 6, 14);
        } 
    }
}
