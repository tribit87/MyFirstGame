using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float Damage;
    [SerializeField] private ParticleSystem ParticleSystem;
    [SerializeField] private AudioSource ExplosionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var hc = other.GetComponent<HealthController>();
            hc.CurrentHealthNew -= Damage;
            Debug.Log("Player HP: " + hc.CurrentHealthNew);
            ParticleSystem.Play();
            ExplosionSound.Play();
            Destroy(gameObject);
        }
    }
}
