using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnaceFlame : MonoBehaviour {
    public AudioClip SoundToPlay;
    public float Volume;
   // public bool spinning = false;

    new AudioSource audio;

    public GameObject furnaceFlamePrefab;
    public Transform furnaceFlameSpawn;
    public bool isLit = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flames")
        {
            if (!isLit)
            {
                Light();
                audio.PlayOneShot(SoundToPlay, Volume);
            }
        }
    }

    void Light()
    {
        if (!isLit)
        {
            Instantiate(furnaceFlamePrefab, furnaceFlameSpawn.position, furnaceFlameSpawn.rotation);
            isLit = true;
            //spinning = true;
        }        
    }
}
