using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausemusic : MonoBehaviour
{
    public AudioClip Music;
    public AudioSource AudioSource;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.Pause();
    }

    private void OnTriggerExit(Collider other)
    {
        AudioSource.UnPause();
    }
}
