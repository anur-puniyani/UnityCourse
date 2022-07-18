using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_210_Shooting : MonoBehaviour
{
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        GameObject obj = GameObject.Instantiate(particle);
        obj.transform.position = transform.position;
        GetComponent<AudioSource>().Play();
    }
}
