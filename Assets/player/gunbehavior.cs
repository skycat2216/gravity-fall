using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunbehavior : MonoBehaviour
{
    public Transform GunModel;
    public Vector3 aimDonwnSight,hipFire; 	
	public float gunrecoil = 50f;
	
	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			
		}
		
        if(Input.GetKeyDown(KeyCode.Mouse1))
		{
			transform.localPosition = Vector3.Slerp
				(transform.localPosition,aimDonwnSight,10*Time.deltaTime);
				
			
		}
		if(Input.GetKeyUp(KeyCode.Mouse1))
		{
			transform.localPosition = hipFire;
		}
		
		
		
    }
}
