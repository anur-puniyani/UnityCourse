using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_301_CreateT : MonoBehaviour
{
    public GameObject original;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject.Instantiate(original, new Vector3(0, i, 0), Quaternion.identity);
        }

        for (int i = 0; i < 3; i++)
        {
            GameObject.Instantiate(original, new Vector3(i-1, 5, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
