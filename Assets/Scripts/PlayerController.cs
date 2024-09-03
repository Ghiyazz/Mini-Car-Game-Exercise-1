using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // this is my private varaible
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal"); // the horizontal input variable
        forwardInput = Input.GetAxis("Vertical"); // the vertical input variable

        // This is to move the vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // This line is to turn the vehicle left and right 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);


    }
}
