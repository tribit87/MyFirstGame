using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGo : MonoBehaviour
{
    [SerializeField] private float Speed;
    public Rigidbody rb;
    
    void Start()
    { 
        rb.velocity = transform.forward * Speed;
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
    
}
