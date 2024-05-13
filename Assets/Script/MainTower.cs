using UnityEngine;
using UnityEngine.UI;

public class MainTower : MonoBehaviour
{
    [SerializeField] private Slider _sliderHp;
    [SerializeField] private Text _textHp;
    [SerializeField] private int _myHp;

    
    void Start()
    {
        _sliderHp.maxValue = _myHp;
        _sliderHp.value = _myHp;
        _textHp.text = _myHp.ToString();

    }
    public void TowerTakeDamage(int volue)
    {
        _myHp -= volue;

        _sliderHp.value = _myHp;
        _textHp.text = _myHp.ToString();
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
            Destroy(controller.gameObject);
        }
    }
   

}  
