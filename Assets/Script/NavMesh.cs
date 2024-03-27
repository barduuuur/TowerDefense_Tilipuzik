using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    [SerializeField] private Transform[] targetsPoint;

    private NavMeshAgent agent;

    private int currentIndex = 0;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(targetsPoint[0].position);
    }

    void Update()
    {

    }
    
}
