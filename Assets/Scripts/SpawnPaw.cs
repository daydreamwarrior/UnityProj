using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPaw : MonoBehaviour
{
    public GameObject Paw;
    float randX;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 7; i++)
        {
            randX = Random.Range(-10f, 10f);
            Instantiate(Paw, new Vector3(randX, 6, 0), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
