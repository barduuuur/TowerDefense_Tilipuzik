using UnityEngine;

public class AudioManager : MonoBehaviour
{
   AudioSource _source;
   AudioSource _source2;
    

    public AudioClip death;
    public AudioClip shooting;
    private void Start()
    {
        _source = GetComponent<AudioSource>();
        _source2 = GetComponent<AudioSource>();
        EventManager.onMusic += PlayMusic;
        //EventManager.onMusic += PlayShootMusic;
    }
    private void OnDisable()
    {
        EventManager.onMusic -= PlayMusic;
        //EventManager.onMusic -= PlayShootMusic;
    }
    public void PlayMusic()
    {
        _source.PlayOneShot(death);
    }
   /* public void PlayShootMusic()
    {
        _source2.PlayOneShot(shooting);
    }*/
}
