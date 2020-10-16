using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousectrl : MonoBehaviour
{
	public Transform playerBody;
	
	public float mouseSensitve = 100f;
	
	float Xrotation;
	float Yrotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = 	CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(270f,0f,90f);
	
		float mouseX = Input.GetAxis("Mouse X")*mouseSensitve*Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y")*mouseSensitve*Time.deltaTime;
		
		Xrotation = mouseX;
		Xrotation = Mathf.Clamp(Xrotation,180f,360f);
		Yrotation = mouseY;
		Yrotation = Mathf.Clamp(Yrotation,-180f,180f);
		
		transform.localRotation = Quaternion.Euler(Xrotation,0f,90f);
		playerBody.Rotate(Vector3.up*mouseX);
		transform.localRotation = Quaternion.Euler(0f,Yrotation,90f);
		playerBody.Rotate(Vector3.right*mouseY);
    }
}
