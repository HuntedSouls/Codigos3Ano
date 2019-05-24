using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float roty = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3(-1*roty*45*Time.deltaTime,0,0));

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y , 0);
        
	}
}
