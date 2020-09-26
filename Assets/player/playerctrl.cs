using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerctrl : MonoBehaviour
{    
	
	public float playerspeed = 10f;

	
	void update()
	{
		// Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float x = Input.GetAxis("Vertical") * playerspeed;
        float z = Input.GetAxis("Horizontal") * playerspeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        x *= Time.deltaTime;
        z *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, z);
		transform.Translate(x, 0, 0);

        // Rotate around our y-axis
        
	}
}