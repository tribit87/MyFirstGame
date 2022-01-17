using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    public float MaxHealthPoints;
    [HideInInspector] public float _currentHealth;
    public Action<float> HealthChanged;

    public float CurrentHealthNew
    {
        get => _currentHealth;
        set
        {
            _currentHealth = value;
            HealthChanged.Invoke(_currentHealth);
        }
    }

    void Start()
    {
        CurrentHealthNew = MaxHealthPoints;
    }

    void Update()
    {
        if (_currentHealth <= 0)
        {
            Debug.Log("Player is dead");
            SceneManager.LoadScene(2);
            return;
        }
    }
}
