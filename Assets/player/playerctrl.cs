using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerctrl : MonoBehaviour
{    
	
	public CharacterController ctrl;
	private Vector3 playervelocity;
	private bool playergrounded;
	private float playerspeed = 10f;	 
	private float height = 1.0f;
	private float gravityvalue = -9.81f;
	
	
	void update()
	{
		playergrounded = ctrl.isGrounded;
        if (playergrounded && playervelocity.y < 0)
        {
            playervelocity.y = 0f;
        }
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(x,0f,y);
		

        
		
		ctrl.Move(move*playerspeed*Time.deltaTime);
		
        
        
	}
}