using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private Transform[] Points;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        var destP = Points[Random.RandomRange(0, Points.Length)];
        if (!agent.pathPending && agent.remainingDistance <= 0.5f )
        {
            agent.destination = destP.position;
        }
    }
}
