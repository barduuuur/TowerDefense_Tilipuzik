using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;
using System;

public class Shooting : MonoBehaviour
{
    public static Action onPlayMusic;

    [SerializeField] private Transform Gun;
    [SerializeField] private Transform fireObject;
    [SerializeField] private GameObject Core;
    private Rigidbody rb;
    private float Distans;
    private float time_shoot = 0.05f;
   [SerializeField] private GameObject target;


    void Update()
    {
        if (target != null)
        {
            TargetAim();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")&& target==null)
        {
            target = other.gameObject;
            StartCoroutine(Shoot());
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
            StartCoroutine(Shoot());
        }
    }
            
    void TargetAim()
    {
        Gun.LookAt(target.transform);
    }
   IEnumerator Shoot()
    {
        while (Core != null)
        {
            GameObject PrefabBolled = Instantiate(Core, fireObject.position, Quaternion.identity);
            fireObject.transform.LookAt(target.transform.position);
            
            Rigidbody rb = PrefabBolled.GetComponent<Rigidbody>();
            rb.AddForce(fireObject.forward * 25f, ForceMode.Impulse);
            
            yield return new WaitForSeconds(1f);
            
        }
    }

}
