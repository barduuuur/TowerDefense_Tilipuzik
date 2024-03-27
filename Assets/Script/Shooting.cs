using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject weapon;
    private Transform target;

   
    void Start()
    {
        target = FindObjectOfType<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        TargetAim();
    }
    void TargetAim()
    {
        transform.LookAt(target);
    }

}
