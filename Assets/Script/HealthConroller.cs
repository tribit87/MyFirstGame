using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthConroller : MonoBehaviour
{
    [SerializeField] private float MaxHealthPoints;
    [HideInInspector] public float _currentHealth;
    
    void Start()
    {
        _currentHealth = MaxHealthPoints;
    }

    void Update()
    {
        if (_currentHealth <= 0)
        {
            Debug.Log("Player is dead");
            return;
        }
    }
}
