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
	private float gravityvalue = -10f;
	
	
	void Update()
	{
		
		playervelocity.y = gravityvalue*Time.deltaTime; 
		ctrl.Move(playervelocity*Time.deltaTime);
		
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
        
		Vector3 move = transform.right*x+transform.forward*z;
		
		
		ctrl.Move(move*playerspeed*Time.deltaTime);
		
		//----------------------------------------------------------------------------------
		
		
        
        
	}
}