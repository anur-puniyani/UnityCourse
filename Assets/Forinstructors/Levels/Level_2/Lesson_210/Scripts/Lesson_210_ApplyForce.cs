using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_210_ApplyForce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 15, ForceMode.Impulse);
            GetComponent<AudioSource>().Play();
        }
    }
}
