using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthConroller : MonoBehaviour
{
    [SerializeField] private float MaxHealthPoints;
    [HideInInspector] public float _currentHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = MaxHealthPoints;
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentHealth <= 0)
        {
            Debug.Log("Player is dead");
            return;
        }
    }
}
