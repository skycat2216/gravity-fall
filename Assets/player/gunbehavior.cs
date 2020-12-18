using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunbehavior : MonoBehaviour
{
    public Transform GunModel;
    
	public Camera aimCam;
    public Camera mainCam;
 	
	public float gunrecoil = 50f;
	public float weaponRange = 50f;
	public static bool triggered = false; 

	
    public float firerate = 0.1f;
	private float nextFire=0;  
	
	// Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {	
		if(Input.GetKeyDown(KeyCode.Mouse0)&&Time.time >= nextFire+firerate)
		{
			nextFire = Time.time;
			triggered = true;
		}
		if(Input.GetKeyUp(KeyCode.Mouse0))
		{
			nextFire = 0;
			triggered = false;
		}
		
        if(Input.GetKeyDown(KeyCode.Mouse1))
		{
			aimCam.enabled = true;
			
            mainCam.enabled = false;
				
			
		}
		if(Input.GetKeyUp(KeyCode.Mouse1))
		{
			aimCam.enabled = false;
			
            mainCam.enabled = true;
		}
		
		
		
    }
}
