using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InicializaPosicao : MonoBehaviour
{
    public GameObject plat1;
    public GameObject plat2;
    public GameObject plat3;

    List<int> positions = new List<int>(); 
    // Start is called before the first frame update
    void Start()
    {
        System.Random rand = new System.Random();
        for (int i=0;i<3;i++)
        {
            int posx = rand.Next(20) - 10;
            int posy = rand.Next(10) - 5;
            positions.Add(posx);
            positions.Add(posy);
        }
        plat1.transform.position = new Vector2(positions[0], positions[1]);
        plat2.transform.position = new Vector2(positions[2], positions[3]);
        plat3.transform.position = new Vector2(positions[4], positions[5]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
