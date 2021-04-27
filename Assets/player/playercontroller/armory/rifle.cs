using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifle : Weapon
{
    // Start is called before the first frame update
    private float cooldownTime = 0f;
    private float mag = 5;
    private int magSize = 5;
    private GameObject Muzzle = GameObject.Find("RifleMuzzle");
    public void Rifle() 
    {
       [inject]
    }

    public void Cooldown( float time ) 
    {
        cooldownTime -= time;
    }

    public void Fire() 
    {
        
        if ( cooldownTime <= 0f &&　mag>0) 
        {
            RayCast.GetRay();
            RayCast.GetRay(Muzzle.transform.position,Vector3.forward,0f);     

            cooldownTime = 0.1f;
            mag = mag - 1;
            if (mag == 0)
            {
                reload();
            }
        }
    }

    public void reload()
    {
        mag = magSize;
    }


}
