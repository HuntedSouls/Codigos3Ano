using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento3d : MonoBehaviour {

    CharacterController controle;
    float altura = 5.0f;
    float gravidade = -10.0f;
    Vector3 movimento = Vector3.zero;

    Transform olhos;

    // Use this for initialization
    void Start () {
        controle = GetComponent<CharacterController>();
        olhos = GetComponentInChildren<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        transform.localRotation = olhos.localRotation;

        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");
        float rotx = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0,rotx*45*Time.deltaTime,0));


        Vector3 movendo = movX * transform.right + movZ * transform.forward;
        movimento.x =  movendo.x;
        movimento.z =  movendo.z;




        if (Input.GetKeyDown(KeyCode.Space) && controle.isGrounded)
        {
            movimento.y = altura; 
        }

        movimento.y += gravidade*Time.deltaTime;

        controle.Move(movimento*Time.deltaTime);
	}
}
