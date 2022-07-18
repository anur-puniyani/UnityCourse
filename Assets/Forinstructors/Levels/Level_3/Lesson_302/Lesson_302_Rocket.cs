using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_302_Rocket : MonoBehaviour
{
    public GameObject explosionEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 50, ForceMode.Impulse);
        GetComponent<AudioSource>().Play();
        GameObject explosionClone = GameObject.Instantiate(explosionEffect);
        explosionClone.transform.position = transform.position;
        }
    }
}
