using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento3d : MonoBehaviour {

    CharacterController controle;
    float altura = 20.0f;
    float gravidade = -30.0f;


    // Use this for initialization
    void Start () {
        controle = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");
        Vector3 movimento = new Vector3(movX,0,movZ);

        if (Input.GetKeyDown(KeyCode.Space) && controle.isGrounded)
        {
            movimento.y += altura; 
        }

        movimento.y += gravidade*Time.deltaTime;

        controle.Move(movimento*Time.deltaTime);
	}
}
