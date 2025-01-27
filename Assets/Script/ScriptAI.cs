using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ScriptAI : MonoBehaviour
{
    public NavMeshAgent NPC;
    public Transform player;
    public Transform[] points;
    private int currentPointIndex = 0;
    private void Start()
    {
        NPC = GetComponent<NavMeshAgent>();
        if (points.Length > 0)
        {
            NPC.SetDestination(points[currentPointIndex].position);
        }
    }
    void Update()
    {
        if (points.Length == 0) return;
        if(!NPC.pathPending && NPC.remainingDistance <= NPC.stoppingDistance)
        {
            currentPointIndex = (currentPointIndex + 1) % points.Length;
            NPC.SetDestination(points[currentPointIndex].position);
        }
        
    }
}
