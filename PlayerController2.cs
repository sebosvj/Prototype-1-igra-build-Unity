using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    // public Vector3 speed;
    // Start is called before the first frame update
    private float speed = 15.0f;
    private float turnSpeed = 45.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // transform.Translate(speed * Time.deltaTime);
        // kretnje lika
        if (Input.GetKey("right"))
        {
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * 1);
            
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * -1);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * 1);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * -1);
        }
    }
}