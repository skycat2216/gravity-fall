using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifle : Weapon
{
    // Start is called before the first frame update
    private readonly Foo.Factory rifleBulletPool;
    private readonly List<Foo> _Foos = new List<Foo>();
    private float cooldownTime;
    private float mag;

    public void Rifle( Foo.Factory rifleBulletPool ) {
        this.bulletPool = bulletPool;
    }

    public void Cooldown( float time ) {
        cooldownTime -= time;
    }

    public void Fire( Vector3 position, Vector3 direction ) {
        if ( cooldownTime <= 0f &&　mag>0) 
        {
            Bullet bullet = bulletPool.Spawn();
            bullet.SetPosition( position );
            bullet.SetVelocity( direction * 10f );

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
        
    }


}
