using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpCoinManager : MonoBehaviour
{
    public GameObject PlayerHeart;
    public Text TextPlayerMoney;
    bool Draw = true;
    public static float PlayerHp = 100;
    public static int PlayerMoney=0;
    
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
        
    }

    // Update is called once per frame
    void Update()
    {
        TextPlayerMoney.text = PlayerMoney.ToString();
    }
}
