using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Turrel : MonoBehaviour
{
    private bool isNear;
    private Transform target;
    
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
        if (isNear)
        {
            transform.LookAt(target);
        }
    }
}
