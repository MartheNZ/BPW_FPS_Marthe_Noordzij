using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleEnter : MonoBehaviour {

    public AudioClip SoundToPlay;
    public float Volume;
    new AudioSource audio;
    private bool alreadyPlayed = false;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            if (!alreadyPlayed)
            {
                audio.PlayOneShot(SoundToPlay, Volume);
                alreadyPlayed = true;
            }
        }
    }

}
