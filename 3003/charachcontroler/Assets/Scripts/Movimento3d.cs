using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento3d : MonoBehaviour {

    CharacterController controle;
    public float velocidade = 3.0f;

    IEnumerator Pular()
    {
        Vector3 pulo = new Vector3(0, 5, 0);
        controle.Move(pulo);
        yield return null;

    }

	// Use this for initialization
	void Start () {
        controle = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        float direcaoX = Input.GetAxis("Horizontal");
        float direcaoZ = Input.GetAxis("Vertical");
        Vector3 movimento = new Vector3(direcaoX,0,direcaoZ);
        controle.SimpleMove(movimento*velocidade);

        if (Input.GetKeyDown(KeyCode.Space) && controle.isGrounded)
        {
            StartCoroutine(Pular());
        }
	}
}
