using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento3d : MonoBehaviour {

    CharacterController controle;
    public float velocidade = 3.0f;
    Vector3 movimento = Vector3.zero;
    public float alturaPulo = 5.0f;
    public float gravidade = -10.0f;
    Transform olhos;

    IEnumerator Pular()
    {
        Vector3 pulo = new Vector3(0, 5, 0);
        for (int i =0;i<10;i++)
        {
            controle.Move(pulo/10);
            yield return new WaitForSeconds(0.1f);
        }

    }

	// Use this for initialization
	void Start () {
        controle = GetComponent<CharacterController>();
        olhos = GetComponentInChildren<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        

        float direcaoX = Input.GetAxis("Horizontal");
        float direcaoZ = Input.GetAxis("Vertical");
        Vector3 movendo = Vector3.zero;

        movendo = transform.right * direcaoX + transform.forward * direcaoZ;

        movimento.x = movendo.x;
        movimento.z = movendo.z;

        transform.Rotate(0, Input.GetAxis("Mouse X") * 90 * Time.deltaTime, 0);

        if (controle.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            movimento.y = alturaPulo;
        }
        else
        {
            movimento.y += gravidade * Time.deltaTime;
        }
        controle.Move(movimento*velocidade*Time.deltaTime);
        
	}
}
