using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotorSpin : MonoBehaviour {
    public bool spinning = false;

    public AudioClip SoundToPlay;
    public float Volume;
    new AudioSource audio;
    private bool audioPlaying = false;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (spinning == true)
        {
            transform.Rotate(Vector3.up, 450 * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flames")
        {
            if(!audioPlaying)
            {
                audio.PlayOneShot(SoundToPlay, Volume);
                audioPlaying = true;
            }
            

            spinning = true;
        }
    }
}
