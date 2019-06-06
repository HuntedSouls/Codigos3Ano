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
            tiro.transform.position = transform.position + transform.forward ;
            tiro.transform.forward = transform.forward;
            tiro.transform.Rotate(new Vector3(90,0,0));
            tiro.GetComponent<Rigidbody>().AddForce(GetComponentInChildren<Transform>().forward*10, ForceMode.Impulse);
            Debug.Log(GetComponentInChildren<Transform>().forward);
        }
	}
}
