﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public bulletpool pool;
 
    public float Firerate = 0.2f;
    private float NextFire=0;
	

    // Update is called once per frame
    void Update()
    {
         if(gunbehavior.triggered==true)
		{
			pool.ReUse(transform.position,transform,rotation);
		}
    }
}
