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
            Vector3 spawnPosition = new Vector3(
                transform.position.x, 
                transform.position.y + 0.5f,
                transform.position.z
                );



            Instantiate(place, spawnPosition, Quaternion.identity);
            IsPlacement = false;
        }
    }
   
}
