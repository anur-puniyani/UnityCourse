using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_303_Use_Chomper_Run : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        if(Vector3.Distance(player.transform.position, transform.position) < 12)
        {
            GetComponent<Animator>().SetBool("ShouldAttack", true);
            GetComponent<Animator>().SetBool("ShouldRun", false);
        }
        else{
            GetComponent<Animator>().SetBool("ShouldRun", true);
            GetComponent<Animator>().SetBool("ShouldAttack", false);
        }
    }

   /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {

        GetComponent<Animator>().SetBool("IsHit", true);
        GetComponent<Animator>().SetBool("ShouldRun", false);
        Invoke("ResetHit", 1);

    }

    void ResetHit()
    {
        GetComponent<Animator>().SetBool("IsHit", false);
        GetComponent<Animator>().SetBool("ShouldRun", true);
    }
}
