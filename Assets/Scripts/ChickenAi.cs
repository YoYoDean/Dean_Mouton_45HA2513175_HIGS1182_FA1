using UnityEngine;
using UnityEngine.AI;

public class ChickenAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public float patrolRadius = 5f;

    private Vector3 startPoint;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        startPoint = transform.position;

        SetNewDestination();
    }

    void Update()
    {
        // If reached destination, pick a new one
        if (!agent.pathPending && agent.remainingDistance < 2f)
        {
            SetNewDestination();
        }
    }

    void SetNewDestination()
    {
        Vector3 randomPoint = startPoint + Random.insideUnitSphere * patrolRadius;

        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, patrolRadius, NavMesh.AllAreas))
        {
            agent.SetDestination(hit.position);
        }
    }
}
