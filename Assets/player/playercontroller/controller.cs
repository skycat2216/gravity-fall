using UnityEngine;
using Zenject;


public class controller : ITickable
{

    private readonly playerctrl Player; //readonly
	private readonly Armony armony; //readonly
	private Transform muzzle;
	
	public controller(playerctrl Player, Armony armony)
	{
		Cursor.lockState = CursorLockMode.Locked;
		this.Player = Player;
		this.armony = armony;
		
	}
	public void Tick()
	{
		Player.move();
								
		Player.spincam(Input.GetAxis("Mouse X"),
					   Input.GetAxis("Mouse Y"));					
		
		armony.Cooldown(Time.deltaTime);
		
		if(Input.GetButton("Fire1"))
		{
			
			armony.FireCurrentWeapon();
		}
		
		 if ( Input.GetButtonDown( "LeftArrow" ) ) 
		{
            armony.SwitchRight();
        }

        if ( Input.GetButtonDown( "RightArrow" ) ) 
		{
            armony.SwitchLeft();
		}
	}
    
}
