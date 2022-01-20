using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private DoorType Door;
    [SerializeField] private AudioSource DoorSound;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var pc = other.GetComponent<PlayerController>();
            if (pc.HasKey(Door))
            {
                DoorSound.Play();
                //Open();
                Destroy(gameObject);
            }
        }
    }

    /*private void Open()
    {
        
    }*/
}
