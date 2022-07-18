using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_200_Completed : MonoBehaviour
{
    public GameObject original;
    void Start()
    { 
        GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Debug.Log("Inside Start");
        Debug.Log("I am a great programmer");
    }
    void Update()
    { 
        GameObject.Instantiate(original);
        
        Debug.Log("Inside Update");
    } 
}//End of class
