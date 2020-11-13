using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallrun : MonoBehaviour
{
	public CharacterController ctrl;
	private Vector3 playervelocity;
	
	public Transform wallcheckleft;
	public Transform wallcheckright;
	public float walldistance = 0.4f;
	public LayerMask wallmask;
	private bool wallrunleftcheck,wallrunrightcheck;
    // Start is called before the first frame update
    void Start()
    {
        ctrl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        wallrunleftcheck = Physics.CheckSphere(wallcheckleft.position, walldistance, wallmask);
		
		if (wallrunleftcheck == true || wallcheckright == true && playervelocity.y <0)
		{
			playervelocity.y = 0;
		}
    }
}
