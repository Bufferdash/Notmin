using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    public float speed, gravity, jumpForce, gravityMultiplier;
    float hInput, vInput;   //horizontal and vertical inputs
    float playerFoot;   //this is the position of the player's "foot"

    float dGravity; //this is the gravity we'll use to pull the player down
    public float rotateSpeed;
    float rotationHor;

	// Use this for initialization
	void Start () 
    {
        dGravity = gravity * gravityMultiplier; //set downward gravity
        rb = GetComponent<Rigidbody>();
        playerFoot = GetComponent<Collider>().bounds.extents.y;
        Cursor.lockState = CursorLockMode.Locked;   //lock mouse in center of screen
        Cursor.visible = false; //makes mouse invisible
	}
	
	// Update is called once per frame
	void Update () 
    {
        //MOVEMENT
        //Move Forward
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        //Move Backward
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }
        //Move Right
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        //Move Left
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        }
	}

    //Update is called once per frame
    private void FixedUpdate()
    {
        if(rb.velocity.y > 0)   //before we hit the apex of the jump, use normal gravity
        {
            rb.AddForce(-transform.up * gravity, ForceMode.Acceleration);   //this is our custom gravity
        }
        else
        {
            rb.AddForce(-transform.up * dGravity, ForceMode.Acceleration);  //gravity is higher on fall
        }

        //JUMPING
        if(Input.GetKeyDown(KeyCode.Space)) // && IsGrounded())
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.VelocityChange);    //adds instant velocity change, ignore mass
        }

        //Mouse Rotation
        rotationHor = Input.GetAxis("Mouse X") * rotateSpeed;   //rotationHor tracks the mouse movement along the x axis
        transform.Rotate(0, rotationHor, 0);    //set the player rotation using rotationHor
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, playerFoot + 0.05f);
    }
}
