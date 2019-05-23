using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float rotx = Input.GetAxis("Mouse X");
        float roty = Input.GetAxis("Mouse Y");
        transform.Rotate(new Vector3(-1*roty*15,0,0));
        //float finalRotx = Mathf.Clamp(transform.rotation.eulerAngles.x, -80.0f,80.0f);
        /*float rotX = transform.rotation.eulerAngles.x;
        if (0 > rotX && rotX > 80)
        {
            Debug.Log(rotX.ToString());
            rotX = 80;
        }
        if(rotX < -80)
        {

            rotX = -80;
        }

        transform.rotation = Quaternion.Euler(rotX, transform.rotation.eulerAngles.y , 0);
        */
	}
}
