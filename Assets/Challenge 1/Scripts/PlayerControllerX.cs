using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 10.0f;
    public float rotationSpeed;
    public float verticalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame #20JJ0CR8L
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        forwardInput = Input.GetAxis("Horizontal");
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward *Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * (-verticalInput));
    }
}
