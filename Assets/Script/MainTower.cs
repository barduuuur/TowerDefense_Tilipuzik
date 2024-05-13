using UnityEngine;
using UnityEngine.UI;

public class MainTower : MonoBehaviour
{
   
    [SerializeField] private Text _myhp;
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
