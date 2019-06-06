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
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameObject tiro = Instantiate(bala);
            tiro.transform.position = transform.position + transform.forward*2;
            tiro.GetComponent<Rigidbody>().AddForce(transform.forward*50,ForceMode.Impulse);
        }
		
	}
}
