using UnityEngine;

[CreateAssetMenu(fileName = "Character states", menuName = "Stats/Character states")]

public class EnemyStats : ScriptableObject
{
    [SerializeField] private int _price;

    public int HP;
    public int Damage;
    public int Speed;
    public int Price => _price;
}
