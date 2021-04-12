using System.Collections.Generic;
using UnityEngine;

public class Armony {
    private readonly List<Weapon> weapons;
    private int currentIndex = 0;

    public Armony( List<Weapon> weapons ) 
	{
        this.weapons = weapons;
    }

    public Transform Getmuzzle()
    {
        Transform Muzzle = weapons[currentIndex].muzzle();
        return Muzzle;
    }

    public void Cooldown( float time ) 
	{
        weapons[currentIndex].Cooldown( time );
    }

    public void FireCurrentWeapon( Vector3 position, Vector3 direction ) 
	{
        weapons[currentIndex].Fire( position, direction );
    }
	
	public void ReloadWeapon()
	{
		weapons[currentIndex].reload();
	}

    public void SwitchRight() {
        ++currentIndex;
        if ( currentIndex == weapons.Count ) 
		{
            currentIndex = 0;
			//animation:trigger(swapping);
        }
    }

    public void SwitchLeft() {
        --currentIndex;
        if ( currentIndex == -1) 
		{
            currentIndex = weapons.Count - 1;
			//animation:trigger(swapping);
        }
    }
}