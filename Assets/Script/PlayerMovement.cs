using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    private Rigidbody rb;
    public bool IsOnGround = false;
    [SerializeField] private float force;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            IsOnGround = true;
        }
    }
    
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            IsOnGround = false;
        }
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        rb.AddForce(((transform.right * x) + (transform.forward * z)) * Speed);

        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround == true)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }

    }
}
