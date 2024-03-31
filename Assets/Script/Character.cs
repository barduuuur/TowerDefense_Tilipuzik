using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private CharacterObjext characterObjext;

    private int hp;
    private int damage;
    private int speed;

    void Start()
    {
        hp = characterObjext.HP;
        damage = characterObjext.Damage;
        speed = characterObjext.Speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
