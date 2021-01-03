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

	
    public float firerate = 0.5f;
	private float nextFire=0f;  
	
	// Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {	
		if(Input.GetKeyDown(KeyCode.Mouse0) && nextFire + Time.deltaTime >= firerate)
		{
			triggered = true;
			if(triggered == true)
			{
				Debug.Log("test");
			}
			else
            {
				Debug.Log("nope");
            }
			nextFire = 0f;
		}
		if(Input.GetKeyUp(KeyCode.Mouse0))
		{
			nextFire = 0f;
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
