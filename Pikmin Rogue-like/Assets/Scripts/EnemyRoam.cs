using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRoam : MonoBehaviour
{
    /*
    //Example 1
    Vector3 startPosition;
    public int roamRadius;
    */


    // Use this for initialization
    void Start()
    {
        /*
        //Example 1
        startPosition = transform.position;
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        // Example 1
        Vector3 randomDirection = UnityEngine.Random.insideUnitSphere * roamRadius;
        randomDirection += startPosition;
        UnityEngine.AI.NavMeshHit hit;
        UnityEngine.AI.NavMesh.SamplePosition(randomDirection, out hit, roamRadius, 1);
        Vector3 finalPosition = hit.position;
        _nav.destination = finalPosition;
        */
    }
}