using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    [SerializeField] private float healthPoints;
    [SerializeField] private AudioSource HealingSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var hc = other.GetComponent<HealthController>();
            hc.CurrentHealthNew += healthPoints;
            Debug.Log(hc.CurrentHealthNew);
            HealingSound.Play();
            Destroy(gameObject);
        }
    }
}
