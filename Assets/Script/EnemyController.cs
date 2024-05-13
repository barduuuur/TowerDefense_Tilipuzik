using UnityEngine;
using UnityEngine.AI;
using System;

public class EnemyController : MonoBehaviour
{
    public static Action onMusic;
    [SerializeField] private Transform targetsPoint;
    [SerializeField] private EnemyStats _enemyStats;

    AudioManager audioManager;
    private int _myPrice;
    private int _speed;
    [SerializeField] private int _myHp;
    public int _damage;
    private NavMeshAgent agent;
    private GoldController goldController;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetsPoint =  GameObject.FindWithTag("MainTower").transform;
        agent.SetDestination(targetsPoint.position);
        goldController = FindAnyObjectByType<GoldController>();

        _speed = _enemyStats.Speed;
        _myHp = _enemyStats.HP;
        _myHp = _enemyStats.myPrise;
        _damage = _enemyStats.Damage;
        agent.speed = _speed;
        _myPrice = _enemyStats.Price;

    }

    public void TakeDamage(int volue)
    {
        _myHp -= volue;
        if (_myHp < 0)
        {
            EventManager.onMusic?.Invoke();
            goldController.AddGold(_myPrice);
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
