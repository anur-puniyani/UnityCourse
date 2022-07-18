using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField]
    GameObject barrel;

    [SerializeField]
    GameObject bullet;

    float previousMouseX;

    float previousMouseY;

    bool isFirstFrame;

    AudioSource source;

    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        isFirstFrame = true;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            GameObject bulletClone = GameObject.Instantiate(bullet);

            bulletClone.transform.position = barrel.transform.position;
            bulletClone.transform.up = barrel.transform.forward;

             //  bulletClone.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

            Rigidbody rgb = bulletClone.GetComponent<Rigidbody>();

            rgb.AddForce(barrel.transform.forward * 200, ForceMode.Impulse);
            if(!source.isPlaying)
                source.Play();
        }

       if(!isFirstFrame)
       {
            float deltaX = Input.mousePosition.x - previousMouseX;

            float deltaY = Input.mousePosition.y - previousMouseY;

            transform.Rotate(Vector3.up, deltaX  / 2, Space.World);

            transform.Rotate(transform.forward, deltaY  / 2, Space.World);
       } 
       else if(isFirstFrame)
       {
           isFirstFrame = false;
       }
        previousMouseX =  Input.mousePosition.x;
        previousMouseY =  Input.mousePosition.y;

        Vector3 forward = transform.right;

        forward.y = 0;

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(forward * Time.deltaTime * speed , Space.World);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(-forward * Time.deltaTime * speed , Space.World);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
        }
         if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(-transform.forward * Time.deltaTime * speed, Space.World);
        }
    }
}
