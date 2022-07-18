using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common_Collect : MonoBehaviour
{

    public bool playAudio;
    public bool playParticle;

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
       
       
        if(playParticle)
        {
            GameObject particleClone = GameObject.Instantiate(particle);
            particleClone.transform.position = transform.position;
        }
         if(playAudio)
            GetComponent<AudioSource>().Play();

    }
}
