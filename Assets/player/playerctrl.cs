using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerctrl : MonoBehaviour
{
	    Transform trans;                                                         //-----b.
    Rigidbody rigid;                                                      //-----c.
    // Use this for initialization
    void Start () {                                                               //-----d.
        trans = GetComponent<Transform>();                   //-----e.
        rigid = GetComponent<Rigidbody>();                //-----
	
}


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {                  //-----h.
            trans.Translate(Vector3.left * Time.deltaTime);   //-----i.
        }else if (Input.GetKey(KeyCode.D)) {       //-----j.
            trans.Translate(Vector3.right * Time.deltaTime); //-----k.
        }else if (Input.GetKey(KeyCode.W)) {
			trans.Translate(Vector3.forward * Time.deltaTime);
		}else if (Input.GetKey(KeyCode.S)) {
			trans.Translate(Vector3.down * Time.deltaTime);
		}

        if (Input.GetKeyDown(KeyCode.Backspace)) {          
            rigid.AddForce(Vector3.up * 200);
		}
    }
}
