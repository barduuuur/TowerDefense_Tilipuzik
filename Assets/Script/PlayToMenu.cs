using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayToMenu : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Quit()
    {
       Application.Quit();
        
    }
}
