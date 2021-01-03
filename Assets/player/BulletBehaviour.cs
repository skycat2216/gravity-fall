using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
	public bulletpool pool;
	
	private Transform _myTransform;
	
	void Awake()
	{
		_myTransform = transform;
	}

    // Update is called once per frame
    void Update()
    {
         if(gunbehavior.triggered==true)
		{
			pool.ReUse(_myTransform.position,_myTransform.rotation);
		}
    }
}
