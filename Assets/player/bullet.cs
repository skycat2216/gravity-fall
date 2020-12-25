using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
	public bool hitbox;

    // Update is called once per frame
    void Update()
    {
        hitbox = Physics.CheckSphere
			(groundcheck.position, grounddistance, groundmask);
			
		if(hitbox==true)
		{
			bulletpool.Recycle();
		}
    }
}
