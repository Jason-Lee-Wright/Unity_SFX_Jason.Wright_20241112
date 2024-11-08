using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public AudioSource Meow;

    private void OnTriggerEnter(Collider other)
    {
        Meow.Play();
    }
}
