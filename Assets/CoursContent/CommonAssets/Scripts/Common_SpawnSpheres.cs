using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common_SpawnSpheres : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.AddComponent<Rigidbody>();
            sphere.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
        
    }
}
