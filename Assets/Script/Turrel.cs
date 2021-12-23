using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Turrel : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float force;
    [SerializeField] private Transform FirePoint;
    private bool isNear;
    private Transform target;
    private float coolDown = 1f;
    private float currentTime = 0;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNear = true;
            target = other.transform;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isNear = false;
        }
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        if (isNear && currentTime >= coolDown)
        {
            transform.LookAt(target);
            Shoot();
        }
    }
    
    void Shoot ()
    {
        GameObject bullet = Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(FirePoint.forward * force, ForceMode.Impulse);
    }
}
