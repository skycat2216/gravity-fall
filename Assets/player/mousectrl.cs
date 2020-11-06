﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousectrl : MonoBehaviour
{
	public Transform playerBody;
	
	public float mouseSensitve = 100f;
	

	float Xrotation=0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = 	CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
	
		float mouseX = Input.GetAxis("Mouse X")*mouseSensitve*Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y")*mouseSensitve*Time.deltaTime;
		
		Xrotation -= mouseY;
		
		Xrotation = Mathf.Clamp(Xrotation,-90f,90f);
		
		transform.localRotation = Quaternion.Euler(Xrotation,0f,0f);
		playerBody.Rotate(Vector3.up*mouseX);
		
		
    }
}
