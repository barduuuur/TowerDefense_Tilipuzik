using UnityEngine;

[CreateAssetMenu(fileName = "Character states", menuName = "Stats/Character states")]

public class EnemyStats : ScriptableObject
{
    public int HP;
    public int Tower_HP;
    public int Damage;
    public int Speed;
}
