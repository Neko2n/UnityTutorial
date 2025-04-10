using System;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem.Controls;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        // Get user input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward based on user input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Turn the car based on user input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
