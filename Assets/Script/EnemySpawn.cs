using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawn : MonoBehaviour
{
    public Transform Position;
    public GameObject EnemyPrefab;

    void Start()
    {
        var e01 = Instantiate(EnemyPrefab, Position.position, Quaternion.identity);
    }

}
