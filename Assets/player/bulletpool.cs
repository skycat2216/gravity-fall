using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletpool : MonoBehaviour
{
    public int count=30;
	public GameObject bulletPrefab;
	private Queue<GameObject> bulletmag = new Queue<GameObject>();
	
	
	// Start is called before the first frame update
    private void Awake()
    {
        Initpool();
    }

    // Update is called once per frame
    private void Initpool()
    {
        for(int i=0;i<=count;i++)
		{
			Createbullet();
		}
    }
	private void Createbullet()
	{
		GameObject bullet = Instantiate(bulletPrefab) as GameObject;
		bullet.SetActive(false);
		bulletmag.Enqueue(bullet);
		
	}
	public void ReUse(Vector3 position,Quaternion rotation)
	{
		if(bulletmag.Count>0)
		{
			GameObject reuse = bulletmag.Dequeue();
            reuse.transform.position = position;
            reuse.transform.rotation = rotation;
            reuse.SetActive( true );
		}
		else
		{
			Createbullet();
		}
	}
	public void Recycle(GameObject recycle)
	{
		bulletmag.Enqueue(recycle);
		recycle.SetActive(false);
	}
	
}
