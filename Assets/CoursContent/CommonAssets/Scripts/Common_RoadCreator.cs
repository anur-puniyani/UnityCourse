using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common_RoadCreator : MonoBehaviour
{

    public GameObject roadSection;
    public float roadLength;
    public GameObject runner;

    float lastRoadPos;
    // Start is called before the first frame update
    void Start()
    {
        CreateRoad();
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(lastRoadPos - runner.transform.position.z) < 100)
        {
            CreateRoad();
        }
    }

    void CreateRoad()
    {
        for(int i = 0; i < 100; i++)
        {
            GameObject roadClone = GameObject.Instantiate(roadSection);
            roadClone.SetActive(true);
            roadClone.transform.position = new Vector3(0, 0, lastRoadPos );
            lastRoadPos += roadLength;
        }
    }
}
