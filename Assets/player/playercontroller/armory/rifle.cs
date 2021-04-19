using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifle : Weapon
{
    // Start is called before the first frame update
    private readonly ThePool.Pool rifleBulletPool;
    private readonly List<ThePool> _Pool = new List<ThePool>();
    private float cooldownTime = 0.1f;
    private float mag;
    private int magSize = 5;
    public void Rifle() 
    {
       
    }

    public void Cooldown( float time ) 
    {
        cooldownTime -= time;
    }

    public void Fire() 
    {
        if ( cooldownTime <= 0f &&　mag>0) 
        {
            

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
