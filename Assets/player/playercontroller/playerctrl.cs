using UnityEngine;

public class playerctrl : MonoBehaviour
{    

	private Vector3 Velocity;
	private bool playergrounded;
	private float playerspeed = 10f;	
	private float runspeed = 15f;
	private float height = 1.0f;
	private float gravityvalue = -10f;
	private int JumpCount=2;

	public Transform groundcheck;
	public float grounddistance = 0.4f;
	public LayerMask groundmask;
	private bool groundchecking;

	public Transform playerBody;
	public float mouseSensitve = 100f;

//------------------------------------------------------------------------------------------------

	 Cursor.lockState = CursorLockMode.Locked;

    public void move()
	{
		groundchecking = Physics.CheckSphere(groundcheck.position,
											 grounddistance,
											 groundmask);
		
		if(groundchecking)
		{
			Velocity.y = 0;
			JumpCount = 2;
		}
		else
		{
			Velocity.y += gravityvalue;
		}


		float moveX = Input.GetAxis("Horizontal");

	    float moveZ = Input.GetAxis("Vertical");

		Velocity.x = moveX*playerspeed;

		Velocity.z = moveZ*playerspeed;
	
	}
								
	public void spincam(float mouseX,float mouseY)
	{
		float Xrotation = -mouseY*mouseSensitve*Time.deltaTime;
		
		Xrotation = Mathf.Clamp(Xrotation,-90f,90f);
		
		transform.localRotation = Quaternion.Euler(Xrotation,0f,0f);
		
		playerBody.Rotate(Vector3.up*mouseX*mouseSensitve*Time.deltaTime);
	}

	   
	   		
		

}
