﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float Damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var hc = other.GetComponent<HealthConroller>();
            hc._currentHealth -= Damage;
            Debug.Log(hc._currentHealth);
            Destroy(gameObject);
        }
    }
}