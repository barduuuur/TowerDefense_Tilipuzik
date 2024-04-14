using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTower : MonoBehaviour
{
    [SerializeField] private EnemyStats _enemyStats;
    private int _towerHp;
    void Start()
    {
        _towerHp = _enemyStats.Tower_HP;
    }
    public void TowerTakeDamage(int volue)
    {
        _towerHp -= volue;
        if (_towerHp < 0)
        {
            Destroy(gameObject);
        }
    }
}  
