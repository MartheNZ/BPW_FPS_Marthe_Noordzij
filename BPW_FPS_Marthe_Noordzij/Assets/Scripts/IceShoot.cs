using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceShoot : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    new AudioSource audio;
    private bool audioPlaying = false;

    //public PlayerShoot flameThrower;

    //public ParticleSystem steam;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        //steam = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            print("Release");
            if (audioPlaying == true)
            {
                audio.Stop();
                audioPlaying = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flames")
        {
                      
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Flames")
        {            
            if(transform.localScale.y >= 5)
            {
                transform.localScale += new Vector3(-0.05F, -0.1F, -0.05F);
                if (!audioPlaying)
                {
                    audio.PlayOneShot(SoundToPlay, Volume);
                    print("SFX");
                    audioPlaying = true;
                }
            }
            else {
                audio.Stop();
            }
        }
    }

    /*private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Flames")
        {
            audio.Stop();
            audioPlaying = false;
        }
    }*/




}
