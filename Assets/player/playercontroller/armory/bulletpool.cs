using UnityEngine;
using Zenject;

namespace zenject.nonmonobehaviour
{
public class bulletpool : ITickable
{
    public int count=30;
	public GameObject bulletPrefab;
	private Queue<GameObject> bulletmag = new Queue<GameObject>();
	
	
	// Start is called before the first frame update
    
	
}
}
