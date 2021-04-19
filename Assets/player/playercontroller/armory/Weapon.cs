using UnityEngine;

public interface Weapon 
{
    
    void Fire();
    void Cooldown( float time );
	void reload();


}