using UnityEngine;

public interface Weapon {
    Transform muzzle();
    void Fire( Vector3 position, Vector3 direction );
    void Cooldown( float time );
	void reload();
}