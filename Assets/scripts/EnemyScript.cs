using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public GameObject stalkerDest;
    NavMeshAgent stalkerAgent;

    void Start()
    {
        stalkerAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        stalkerAgent.SetDestination(stalkerDest.transform.position);
    }
}
