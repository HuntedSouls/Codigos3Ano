using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

    float tamanhoDoMovimento = 5;

    Vector3 praOndeEsq ;
    Vector3 praOndeDir ;

    bool dirMovimento = true;

    IEnumerator Movimento()
    {
        yield return null;
    }

    private void OnTriggerEnter(Collider caraquecolidiucomigo)
    {
        if (caraquecolidiucomigo.gameObject.tag  == "Bala")
        {
            Destroy(caraquecolidiucomigo.gameObject);
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        praOndeDir = transform.position + new Vector3(tamanhoDoMovimento/2,0,0);
        praOndeEsq = transform.position - new Vector3(tamanhoDoMovimento/2,0,0);
	}
	
	// Update is called once per frame
	void Update () {
        //StartCoroutine(Movimento());
        if (dirMovimento)
        {
            transform.position = Vector3.MoveTowards(transform.position, praOndeDir, 0.2f);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, praOndeEsq, 0.2f);

        }
        if (transform.position == praOndeDir)
        {
            dirMovimento = false;
        }
        if (transform.position == praOndeEsq)
        {
            dirMovimento = true;
        }
    }
}
