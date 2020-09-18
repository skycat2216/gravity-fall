using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerctrl : MonoBehaviour
{                                                    
	public float mousesensitvex = 5;
	public float mousesensitvey = 5;
	public float playerspeed = 5;
	//def mousesensitve
	private float lookuplimit = 90;
	private float lookdownlimit = 90;
	private float lookleftlimit = -360;
	private float lookrightlimit = 360;
	//def rotate limit
	private Vector3 camrotate = new Vector3(0,0,0);
	//set cam aim point;
	private bool playergrounded;
	
	
	private void start()
	{
		controller = gameObject.AddComponent<CharacterController>();
	}
	
	private bool UpdateMovement() 
	 {
        float distance = playerspeed * Time.deltaTime;   // 移動距離
        playergrounded = controller.isGrounded;
		if (playergrounded &&　)
		{	
			if (Input.GetKey(KeyCode.W)) 
			{
				controller.move()
            
			}

        
			if (Input.GetKey(KeyCode.S)) 
			{
            
            
			}

        
			if (Input.GetKey(KeyCode.A)) 
			{
				
			}
			
			if (Input.GetKey(KeyCode.D)) 
			{
				
			}
		}
        
    }
}