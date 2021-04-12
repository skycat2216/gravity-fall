using UnityEngine;

public interface Weapon 
{
    
    void Fire( Vector3 position, Vector3 direction );
    void Cooldown( float time );
	void reload();
}