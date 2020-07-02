using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetNoseWork : MonoBehaviour
{
    GameObject IN, SP;
    public Image WSkill;
    Color col;
    bool BuyNS = false;
    public static bool SetNS = false;
    // Start is called before the first frame update
    void Start()
    {
        IN = GameObject.FindWithTag("InfoN");
        SP = GameObject.FindWithTag("Space");
        IN.SetActive(false);
        SP.SetActive(false);
        col = WSkill.color;
        col.a = 0.2f;
        WSkill.color = col;
    }

    // Update is called once per frame
    void Update()
    {
        if (BuyNS == true && Input.GetKeyDown(KeyCode.Space) && PlayerHpCoinManager.PlayerMoney >= 10)
        {
            PlayerHpCoinManager.PlayerMoney -= 10;
            BuyNS = false;
            SetNS = true;
            col.a = 1.0f;
            WSkill.color = col;
            IN.SetActive(false);
            SP.SetActive(false);
        }
    }

    public void OnClickNoseWork()
    {
        BuyNS = true;
        IN.SetActive(true);
        SP.SetActive(true);
    }

}
