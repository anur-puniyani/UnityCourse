using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_302_Rocket_Launcher : MonoBehaviour
{
    public GameObject rocket;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 40; i++)
        {
            GameObject rocketClone = GameObject.Instantiate(rocket);
            rocketClone.transform.position = new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
