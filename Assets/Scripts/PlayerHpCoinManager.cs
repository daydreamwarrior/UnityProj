using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpCoinManager : MonoBehaviour
{
    public GameObject PlayerHeart;
    public Text TextPlayerMoney;
    public int PlayerMoney;
    bool Draw = true;
    
    // Start is called before the first frame update
    private void Awake()
    {
        while (Draw)
        {
            Instantiate(PlayerHeart, new Vector3(-7.0f, 4.3f, 0.0f), Quaternion.identity);
            Instantiate(PlayerHeart, new Vector3(-6.0f, 4.3f, 0.0f), Quaternion.identity);
            Draw = false;
        }
    }

    void Start()
    {
        TextPlayerMoney.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
