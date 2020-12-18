using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletpool : MonoBehaviour
{
    public int count=30;
	public GameObject bulletPrefab;
	private List<GameObject> bulletList = new List<GameObject>();
	
	
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
	private GameObject Createbullet()
	{
		GameObject bullet = Instantiate(bulletPrefab) as GameObject;
		bulletList.Add(bullet);
		bullet.transform.SetParent(transform);
		bullet.SetActvity(false);
	}
	public void ReUse(Vector3 position,Quaternion rotation)
	{
		if(bulletList.Count>0)
		{
			GameObject reuse = m_pool.Dequeue();
            reuse.transform.position = position;
            reuse.transform.rotation = rotation;
            reuse.SetActive( true );
		}
		else
		{
			Createbullet();
		}
	}
	
}
