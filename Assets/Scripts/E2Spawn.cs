using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class E2Spawn : MonoBehaviour
{
    public GameObject E2;
    float randX, randY;
    int randMinusPlus;
    //public float Espeed = 3.0f;
    //Vector3 PlayerPos = new Vector3(0f, -4f, 0f);
    //public float MaxHp = 100;

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
                Instantiate(E2, new Vector3(randX, randY, 0), Quaternion.identity);
            }
            else
            {
                randX = Random.Range(5f, 25f);
                randY = Random.Range(-3f, 10f);
                Debug.Log(randX);
                Instantiate(E2, new Vector3(randX, randY, 0), Quaternion.identity);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

}