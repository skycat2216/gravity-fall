using UnityEngine;

public interface Weapon {
    void Cooldown( float time );
    void Fire( Vector3 position, Vector3 direction );
	void reload();
}