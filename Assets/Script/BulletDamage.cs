using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    [SerializeField] private float Damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var hc = other.GetComponent<HealthConroller>();
            hc._currentHealth -= Damage;
            Debug.Log("Player HP: " + hc._currentHealth);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.gameObject.tag == "Enemy")
        {
            var hc = other.GetComponent<EnemyHC>();
            hc._currentEnemyHealth -= Damage;
            Debug.Log("Enemy HP: " + hc._currentEnemyHealth);
        } 
    }
    
}
