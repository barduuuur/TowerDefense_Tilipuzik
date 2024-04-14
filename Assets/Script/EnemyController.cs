using UnityEngine;
using UnityEngine.AI;
using System;

public class EnemyController : MonoBehaviour
{
    public static Action onMusic;
    [SerializeField] private Transform targetsPoint;
    [SerializeField] private EnemyStats _enemyStats;

    AudioManager audioManager;
    private int _myHp;
    private int _damage;
    private NavMeshAgent agent;
    

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetsPoint = GameObject.Find("MainTower").transform;
        agent.SetDestination(targetsPoint.position);

        _myHp = _enemyStats.HP;
        _damage = _enemyStats.Damage;
        
    }

    public void TakeDamage(int volue)
    {
        _myHp -= volue;
        if (_myHp < 0)
        {
            EventManager.onMusic?.Invoke();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainTower"))
        {
            MainTower characterController = other.gameObject.GetComponent<MainTower>();
            characterController.TowerTakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
