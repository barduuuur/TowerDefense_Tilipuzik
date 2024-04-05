using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    private  AudioSource volumeSource;
    void Start()
    {
        volumeSource = GetComponent<AudioSource>();
        volumeSlider.value = volumeSource.volume;
    }

    public void ChangeVolume()
    {
        volumeSource.volume = volumeSlider.value;
    }
    
    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("Save1", volumeSource.volume);
        
        if (PlayerPrefs.HasKey("Save1"))
        {
            PlayerPrefs.GetFloat("Save1");
        }
    }
}
