using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunbehavior : MonoBehaviour
{
    public Transform GunModel;
    
	public Camera aimCam;
    public Camera mainCam;
 	
	public float gunrecoil = 50f;
	public float firerate = 1f;
	public float weaponRange = 50f;  
	public Transform muzzle;
	public GameObject copyGameObject;
    public GameObject superGameObject;

    private GameObject childGameObject;
	
	private LineRenderer laserLine;    
	private float nextFire;  
	
	// Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {	
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			childGameObject = Instantiate(copyGameObject);
			 
            childGameObject.transform.parent = superGameObject.transform;
			
            childGameObject.transform.localPosition = muzzle.transform.position;
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
