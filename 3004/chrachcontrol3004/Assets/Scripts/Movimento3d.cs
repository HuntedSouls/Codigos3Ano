using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento3d : MonoBehaviour {

    CharacterController controle;
    float altura = 5.0f;
    float gravidade = -10.0f;
    Vector3 movimento = Vector3.zero;

    // Use this for initialization
    void Start () {
        controle = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");
        movimento.x = movX;
        movimento.z = movZ;

        float rotx = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, -1 * rotx * 15, 0));

        if (Input.GetKeyDown(KeyCode.Space) && controle.isGrounded)
        {
            movimento.y = altura; 
        }

        movimento.y += gravidade*Time.deltaTime;

        controle.Move(movimento*Time.deltaTime);
	}
}
