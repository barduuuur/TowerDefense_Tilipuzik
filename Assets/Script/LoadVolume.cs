using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadVolume : MonoBehaviour
{
   [SerializeField] AudioSource Source;
    private void Start()
    {

        float volume = PlayerPrefs.GetFloat("Save1", 0.5f);
        Source.volume = volume;
    }
}
