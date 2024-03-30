using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform Gun;
    private GameObject target;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        if(target != null)
        {
            TargetAim();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")&& target==null)
        {
            target = other.gameObject;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && target != null)
        {
            target = null;
            

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && target == null)
        {
            target = other.gameObject;
            
        }
    }
            
    void TargetAim()
    {
        Gun.LookAt(target.transform);
    }
}
