using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transform targetsPoint;
    [SerializeField] private EnemyStats _enemyStats;

    private int _myHp;
    private NavMeshAgent agent;
    

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetsPoint = GameObject.Find("Finish").transform;
        agent.SetDestination(targetsPoint.position);

        _myHp = _enemyStats.HP;
    }

    public void TakeDamage(int volue)
    {
        _myHp -= volue;
        if (_myHp < 0)
        {
            Destroy(gameObject);
        }
    }
    
}
