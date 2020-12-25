using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public bulletpool pool;

    public float Firerate = 0.5f;
    private float NextFire=0;
	
	private Transform _myTransform;
	
	void Awake()
	{
		_myTransform = transform;
	}

    // Update is called once per frame
    void Update()
    {
         if(gunbehavior.triggered==true&&Time.time > NextFire + Firerate)
		{
			pool.ReUse(_myTransform.position,_myTransform.rotation);
			
		}
    }
}
