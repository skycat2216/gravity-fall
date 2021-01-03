using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
	public bool hitbox;
	public Transform hitCheck;
	public float hitDistance = 3.5f;
	public LayerMask hitMask;
	public GameObject self;

	public bulletpool BulletRecycle;

	private float bulletSpeed = 10f;
	private Transform _myTransform;

	void Start()
    {
		
		
		
	}// Update is called once per frame
    void Update()
    {
		hitbox = Physics.CheckSphere
			(hitCheck.position, hitDistance, hitMask);

		transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);

		if (BulletRecycle!=null && hitbox == true)
		{
			BulletRecycle.Recycle(self);
		}
		
		if(Time.deltaTime>1)
        {
			BulletRecycle.Recycle(self);
		}
	}
}
