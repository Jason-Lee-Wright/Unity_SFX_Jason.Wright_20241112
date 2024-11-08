using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLasmaOrb : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
    public AudioSource AudioSource;

    private void OnTriggerEnter(Collider other)
    {
        ParticleSystem.Stop();
        ParticleSystem.Clear();
        AudioSource.Play();
        ParticleSystem.Play();
    }
}
