using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building1 : MonoBehaviour
{
    private bool IsPlacement;

    private void Start()
    {
        IsPlacement = true;
    }

    public void BuildTower(GameObject place)
    {
        if(IsPlacement)
        {
            Instantiate(place, transform.position, Quaternion.identity);
            IsPlacement = false;
        }
    }
   
}
