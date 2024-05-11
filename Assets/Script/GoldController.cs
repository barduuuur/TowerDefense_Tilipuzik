using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldController : MonoBehaviour
{
    [SerializeField] private Text _text;

    private int _myGold;

    private void Start()
    {
        _myGold = 0;
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
}

