using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_303_Chomper_Lives : MonoBehaviour
{

    public GameObject particle;
    public int healthPoints  = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        healthPoints =  healthPoints - 1;

        if(healthPoints <= 0)
        {
            Destroy(gameObject);
            GameObject particleClone = Instantiate(particle);
            particleClone.transform.position = transform.position;
        }
    }
}
