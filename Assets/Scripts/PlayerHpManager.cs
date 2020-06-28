using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHpManager : MonoBehaviour
{
    public GameObject PlayerHeart;
    bool Draw = true;
    // Start is called before the first frame update
    private void Awake()
    {
        while (Draw)
        {
            Instantiate(PlayerHeart, new Vector3(-7.0f, 4.0f, 0.0f), Quaternion.identity);
            Instantiate(PlayerHeart, new Vector3(-6.0f, 4.0f, 0.0f), Quaternion.identity);
            Draw = false;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
