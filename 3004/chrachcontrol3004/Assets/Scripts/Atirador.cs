using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirador : MonoBehaviour {

    public GameObject bala;

    

	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return))
        {
            GameObject tiro = Instantiate(bala);
            tiro.transform.position = Camera.main.transform.position + Camera.main.transform.forward ;
            tiro.transform.forward = transform.forward;
            tiro.transform.Rotate(new Vector3(90,0,0));
            tiro.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 10, ForceMode.Impulse);
            
        }
	}
}
