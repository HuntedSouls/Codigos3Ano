using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorreDiabo : MonoBehaviour {

    IEnumerator MorreComTempo()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(this.gameObject);
    }

	// Use this for initialization
	void Start () {
		
	}

    private void Awake()
    {
        StartCoroutine(MorreComTempo());
    }

    // Update is called once per frame
    void Update () {
		
	}
}
