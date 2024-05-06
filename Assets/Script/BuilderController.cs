using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderController : MonoBehaviour
{
    [SerializeField] private GameObject[] _prefabs;
    private int _index;

    private Camera _camera;
    private Building1 building;
    private bool _builder;

    public static int score =0;

    void Start()
    {
        _camera = Camera.main;
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
                if(hit.collider.TryGetComponent<Building1>(out building))
                {
                    building.BuildTower(_prefabs[_index]);
                    _builder = false;
                }
            }
        }
    }
    public void BuilderTower(int index)
    {
        if (score >= 100)
        {
            _index = index;
            _builder = true;
            score -= 100;
        }
    }

}
