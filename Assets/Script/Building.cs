using UnityEngine;

public class Building : MonoBehaviour
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
