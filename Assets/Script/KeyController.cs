using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] private DoorType Door;
    [SerializeField] private AudioSource KeySound;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var pc = other.GetComponent<PlayerController>();
            pc.GetKey(Door);
            KeySound.Play();
            Destroy(gameObject);
        }
    }
}
