using UnityEngine;
using Zenject;

namespace zenject.nonmonobehaviour
{
public class controller : ITickable
{

    private readonly playerctrl Player;
	private readonly Armony armony;
	private Transform muzzle;
	
	public controller(playerctrl Player, Armony armony)
	{
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
}