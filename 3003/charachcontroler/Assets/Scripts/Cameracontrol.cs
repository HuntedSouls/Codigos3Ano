using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,Input.GetAxis("Mouse X")*90*Time.deltaTime,0 );
        transform.Rotate(-1*Input.GetAxis("Mouse Y") * 90*Time.deltaTime, 0, 0);
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x,transform.eulerAngles.y,0);
    }
}
        
