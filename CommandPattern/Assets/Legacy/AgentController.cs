using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public Transform Waypoint;

    private NavMeshAgent navMeshAgent;

    private void Awake() {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Waypoint) {
            Vector3 positionToMoveTo = Waypoint.position;
            navMeshAgent.destination = positionToMoveTo;
        }

    }
}
