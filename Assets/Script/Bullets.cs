using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private int _damage;

    
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyController characterController = other.gameObject.GetComponent<EnemyController>();
            characterController.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }
}
