using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderController : MonoBehaviour
{
    [SerializeField] private GameObject[] _prefabs;
    [SerializeField] private int[] _towerPrice;

    private int _index;

    private GoldController _controller;
    private Camera _camera;
    private Building building;
    private bool _builder;

    private int currentScore;

    void Start()
    {
        _camera = Camera.main;
        _controller = GameObject.FindAnyObjectByType<GoldController>();

        _index = 0;
        _builder = false;
    }

   
    void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

            if (Input.GetButtonDown("Fire1") && _builder)
        {
            if(Physics.Raycast(ray,out hit))
            {
                if(hit.collider.TryGetComponent<Building>(out building))
                {
                    building.BuildTower(_prefabs[_index]);
                    _builder = false;
                }
            }
        }
    }
    public void BuilderTower(int index)
    {
        currentScore = _controller._myGold;
        _index = index;
        int currentPrice = _towerPrice[_index];

        if (currentScore >= currentPrice)
        {
            
            _builder = true;
            _controller.SubGold(currentPrice);
        }
    }

}
