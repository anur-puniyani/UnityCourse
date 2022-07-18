using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common_RotateScript : MonoBehaviour
{
    public bool rotateAlways;
    public float rotSpeed =  200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) || rotateAlways)
        {
            transform.Rotate(Vector3.right * rotSpeed * Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.right * -rotSpeed * Time.deltaTime);
        }
    }
}
