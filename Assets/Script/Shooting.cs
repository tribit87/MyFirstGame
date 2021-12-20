using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform FirePoint;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float Speed;

    private GameObject _bulletGO;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        GameObject bullet = Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(FirePoint.forward * Speed, ForceMode.Impulse);
    }
    
}
