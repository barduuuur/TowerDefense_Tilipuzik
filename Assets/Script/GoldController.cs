using UnityEngine;
using UnityEngine.UI;

public class GoldController : MonoBehaviour
{

    [SerializeField] private Text _text;

    public int _myGold;

    private void Start()
    {
        _myGold = 1200;
        UpdateGold();
    }

    public void UpdateGold()
    {
        _text.text = _myGold.ToString();
    }

    public void AddGold(int value)
    {
        _myGold += value;
        UpdateGold();
    }

    public void SubGold(int value)
    {
        _myGold -= value;
        if (_myGold <= 0) _myGold = 0;
        UpdateGold();
    }
}

