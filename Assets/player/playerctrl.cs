using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerctrl : MonoBehaviour
{    
	
	public CharacterController ctrl;
	private Vector3 playervelocity;
	private bool playergrounded;
	public float playerspeed = 10f;	 
	public float height = 1.0f;
	public float gravityvalue = -20f;
	
	
	public Transform wallcheckleft;
	public Transform wallcheckright;
	public float walldistance = 0.4f;
	public LayerMask wallmask;
	private bool wallrunleftcheck,wallrunrightcheck;
	
	 void Start()
    {
        ctrl = GetComponent<CharacterController>();

    }
	
	
	void Update()
	{
		playergrounded = ctrl.isGrounded;
		
		if (playervelocity.y < 0 && playergrounded == true)
		{
			playervelocity.y=-2f;
		}
		else
		{
			playervelocity.y += gravityvalue*Time.deltaTime; 
			ctrl.Move(playervelocity * Time.deltaTime);
		}
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
        
		Vector3 move = transform.right*x+transform.forward*z;
		
		
		ctrl.Move(move*playerspeed*Time.deltaTime);
		
		//----------------------------------------------------------------------------------
		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			playervelocity.y = Mathf.Sqrt(height * -2f * gravityvalue);
		}
        
        wallrunleftcheck = Physics.CheckSphere(wallcheckleft.position, walldistance, wallmask);
		
		if (wallrunleftcheck == true || wallcheckright == true && playervelocity.y <0)
		{
			playervelocity.y = 0;
		}
	}
}