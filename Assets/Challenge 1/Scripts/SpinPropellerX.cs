using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 1000f; // The  Speed of the propeller rotation

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        // This is the rotation of the propeller for the forward axis
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
