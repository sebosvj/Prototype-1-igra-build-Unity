using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public Vector3 speed;
    // Start is called before the first frame update
    private float speed = 15.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
         
        // transform.Translate(speed * Time.deltaTime);
        // kretnje lika
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}