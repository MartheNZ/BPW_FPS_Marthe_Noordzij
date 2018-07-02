using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject flamePrefab;
    public Transform flameSpawn;

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
        if (Input.GetButton("Fire1"))
        {
            Fire();
        }
        else if (audioPlaying == true)
        {
            audio.Stop();
            audioPlaying = false;
        }

        else if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
		
	}

    void Fire()
    {
        var flames = (GameObject)Instantiate<GameObject>(flamePrefab, flameSpawn.position, flameSpawn.rotation);
       /* if (!audioPlaying)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            audioPlaying = true;
        }*/

        Destroy(flames, 0.5f);
        
    }
}
