using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_220_Rigidbody_Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 40, ForceMode.Force);
        }
         if(Input.GetKey(KeyCode.DownArrow))
        {
           GetComponent<Rigidbody>().AddForce(-Vector3.forward * 40, ForceMode.Force);
        }
         if(Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddForce(-Vector3.right * 40, ForceMode.Force);
        }
         if(Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 40, ForceMode.Force);
        }
    }
}
