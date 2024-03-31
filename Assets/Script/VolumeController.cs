using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    private AudioSource volumeSource;
    void Start()
    {
        volumeSource = GetComponent<AudioSource>();
        volumeSlider.value = volumeSource.volume;
    }

    public void ChangeVolume()
    {
        volumeSource.volume = volumeSlider.value;
    }
    
    
}
