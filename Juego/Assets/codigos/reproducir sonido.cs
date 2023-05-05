using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reproducirsonido : MonoBehaviour
{
    public AudioSource sonido;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        sonido.clip = clip;
    }

    public void Reproducir()
    {
        sonido.Play();
    }
}
