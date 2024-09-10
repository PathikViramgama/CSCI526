using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    private float turnSpeed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    private float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the vehicle forward
        // transform.Translate(0,0,1);
        // transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Turns the vehicle
        horizontalInput = Input.GetAxis("Horizontal");
        // transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * turnSpeed);
        transform.Rotate(Vector3.up, horizontalInput* turnSpeed * Time.deltaTime *10);
        
        // Moves the car forward
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);

        

        
    }
}
