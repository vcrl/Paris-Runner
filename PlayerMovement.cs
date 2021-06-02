using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Animator animator;
    
    public bool isOnGround;

    public float jumpForce = 2000f;
    public float forwardForce = 2000f;
    public float leftForce = -500f;
    public float rightForce = 500f;

    public float maxSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        isOnGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isOnGround", isOnGround);
        if (transform.position.x <= -5)
        {
            transform.position.Set(-5, 0.619f, 0);
        }

        if (transform.position.x >= 6)
        {
            transform.position.Set(6, 0.619f, 0);
        }
    }
    
    // Physics
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, 0, forwardForce * Time.deltaTime), ForceMode.Force);

        if (rb.velocity.magnitude >= maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
        
        Debug.Log(rb.velocity.magnitude);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            ToggleMovement(true, rightForce);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ToggleMovement(false, leftForce);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
    
    private void OnCollisionStay(Collision other)
    {
        isOnGround = true;
    }

    private void ToggleMovement(bool Movement, float force)
    {
        if (Movement)
        {
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else
        {
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

    private void Jump()
    {
        if (isOnGround)
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
            isOnGround = false;
        }
    }
}
