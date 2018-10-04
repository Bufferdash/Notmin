using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float gravity, jumpForce, gravityMultiplier;
    float playerFoot;

	// Use this for initialization
	void Start () 
    {
        rb = gameObject.GetComponent<Rigidbody>();
        playerFoor = GetComponent<Collider>.bounds.extents.y;
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Move Forward
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        //Move Backward
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward) * speed * Time.deltaTime);
        }

	}

    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {

        }
    }

    boo1 IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, playerFoot + 0.05f)
    }
}
