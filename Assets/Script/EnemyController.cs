using UnityEngine;
using UnityEngine.AI;
using System;

public class EnemyController : MonoBehaviour
{
    public static Action onMusic;
    [SerializeField] private Transform targetsPoint;
    [SerializeField] private EnemyStats _enemyStats;

    AudioManager audioManager;
    private int _speed;
    private int _myHp;
    private int _myPrise;
    public int _damage;
    private NavMeshAgent agent;
    

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetsPoint =  GameObject.FindWithTag("MainTower").transform;
        agent.SetDestination(targetsPoint.position);

        _speed = _enemyStats.Speed;
        _myHp = _enemyStats.HP;
        _myHp = _enemyStats.myPrise;
        _damage = _enemyStats.Damage;
        agent.speed = _speed;
    }

    public void TakeDamage(int volue)
    {
        _myHp -= volue;
        if (_myHp < 0)
        {
           // EventManager.OnAddGold?.Inwoke(_myPrise);
            EventManager.onMusic?.Invoke();
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        BuilderController.score += _myPrise;
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
