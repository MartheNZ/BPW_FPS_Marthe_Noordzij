using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnaceIgnite : MonoBehaviour {
    
    public AudioClip SoundToPlay1;
    public float Volume1;
    public AudioClip SoundToPlay2;
    public float Volume2;
    new AudioSource audio;

    public bool alreadyPlayed = false;

    public bool furnaceIgnite = false;
    public GameObject rotor;
    
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
        
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            transform.position = new Vector3(-56.3F, -6.81F, -68.63F);
            rotor.transform.Rotate(Vector3.up, 450 * Time.deltaTime);
            furnaceIgnite = true;

            if (!alreadyPlayed)
            {
                audio.PlayOneShot(SoundToPlay1, Volume1);
                audio.PlayOneShot(SoundToPlay2, Volume2);
                alreadyPlayed = true;
            }
        }
    }
}
