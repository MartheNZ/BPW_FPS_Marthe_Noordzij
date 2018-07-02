using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootNoise : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    new AudioSource audio;
    private bool audioPlaying = false;

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Fire();
        }
        else if (audioPlaying == true)
        {
            audio.Stop();
            audioPlaying = false;
        }

    }

    void Fire()
    {
        
        if (!audioPlaying)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            audioPlaying = true;
        }
       
    }
}
