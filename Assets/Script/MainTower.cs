using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTower : MonoBehaviour
{
    
    public int _myHp;
    void Start()
    {
        
    }
    public void TowerTakeDamage(int volue)
    {
        _myHp -= volue;
        if (_myHp < 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<EnemyController>(out EnemyController controller))
        {
            TowerTakeDamage(controller._damage);
            Destroy(other.gameObject);
        }
    }
}  
