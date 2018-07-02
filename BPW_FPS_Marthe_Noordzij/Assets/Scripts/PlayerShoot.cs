using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public delegate void shootcallback(Collider collider);
    private new Collider collider = null;
    public bool flameThrower = false;

    public event shootcallback shoot = null;

    void Update()
    {
        
    }

    public void alert(Collider collider)
    {
        this.collider = collider;
    }

        
 
        
       
 }
