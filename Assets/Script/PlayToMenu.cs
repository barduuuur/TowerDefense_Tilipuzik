using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayToMenu : MonoBehaviour
{
    
    public void Quit()
    {
       Application.Quit();
        
    }
    public void LoadLevelIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
}
