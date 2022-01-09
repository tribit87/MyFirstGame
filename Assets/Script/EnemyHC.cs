using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHC : MonoBehaviour
{
    [SerializeField] private float EnemyMaxHealthPoints;
    [HideInInspector] public float _currentEnemyHealth;
    
    void Start()
    {
        _currentEnemyHealth = EnemyMaxHealthPoints;
    }

    void Update()
    {
        if (_currentEnemyHealth <= 0)
        {
            Debug.Log("Enemy is dead");
            Destroy(gameObject);
            return;
        }
    }
}
