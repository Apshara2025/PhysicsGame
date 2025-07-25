using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementForA : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] InputAction thrust;
    [SerializeField] InputAction rotation;
    [SerializeField] float thrustStrength = 10f;
    [SerializeField] float rotationStrength = 100f;

    Rigidbody2D myRigidBody;

    bool controllable = true;
    

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    private void OnEnable()
    {
        thrust.Enable();
        rotation.Enable();

    }

    void Start()
    {
        
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (controllable)
        {
            StartThrusting();
            StartRotating();
        }
    }

    private void StartRotating()
    {
        float rotationInput = rotation.ReadValue<float>();

        if (rotationInput > 0)
        {
            transform.Rotate(-Vector3.forward * Time.fixedDeltaTime * rotationStrength);
        }
        else if (rotationInput < 0)
        {
            transform.Rotate(Vector3.forward * Time.fixedDeltaTime * rotationStrength);
        }
    }

    private void StartThrusting()
    {
        if (thrust.IsPressed())
        {
            myRigidBody.AddRelativeForce(Vector3.up * Time.fixedDeltaTime * thrustStrength);
        }
    }

    
}
