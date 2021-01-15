using UnityEngine;
using Zenject;

namespace zenject.nonmonobehaviour
{
public class controller : ITickable
{
    private readonly playerctrl Player;
	private readonly Armony armony;
	
	public controller(playerctrl Player, Armony armony)
	{
		this.Player = Player;
		this.armony = armony;
	}
	public void Tick()
	{
		Player.move(new Vector3(Input.GetAxis("Horizontal"),
								Input.GetAxis("Jump"),
								Input.GetAxis("Vertical")));
								
		Player.spincam(new Vector3);					
		
		armony.Cooldown(Time.deltaTime);
		
		if(Input.GetButton("Fire1"))
		{
			Transform muzzle = Player.Getmuzzle;
			armony.FireCurrentWeapon(muzzle.position,muzzle.forward);
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