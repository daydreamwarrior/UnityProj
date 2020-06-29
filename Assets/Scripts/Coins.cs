using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject Coin;
    float randX, randY;
    int randMinusPlus;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            randMinusPlus = Random.Range(0, 2);
            if (randMinusPlus == 0)//왼쪽(마이너스)
            {
                randX = Random.Range(-25f, -5f);
                randY = Random.Range(-3f, 10f);
                Debug.Log(randX);
                Instantiate(Coin, new Vector3(randX, randY, 0), Quaternion.identity);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
