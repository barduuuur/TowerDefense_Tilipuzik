using UnityEngine;

public class AudioManager : MonoBehaviour
{
   AudioSource _source;
    public AudioClip clip;

    public AudioClip death;
    public AudioClip shooting;
    private void Start()
    {
        _source = GetComponent<AudioSource>();
        EventManager.onMusic += PlayMusic;
    }
    private void OnDisable()
    {
        EventManager.onMusic -= PlayMusic;
    }
    public void PlayMusic()
    {
        _source.PlayOneShot(clip);
    }
}
