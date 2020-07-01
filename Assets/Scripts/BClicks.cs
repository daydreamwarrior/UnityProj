using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BClicks : MonoBehaviour
{
    bool opened = false;

    GameObject LB, NB, BG, BB, IT;
    GameObject IN, IL;

    // Start is called before the first frame update
    void Start()
    {
        BG = GameObject.FindWithTag("UIBG");
        NB = GameObject.FindWithTag("NoseworkB");
        BB = GameObject.FindWithTag("BuyB");
        IT = GameObject.FindWithTag("InfoT");
        IN = GameObject.FindWithTag("InfoN");
        IL = GameObject.FindWithTag("InfoL");

        NB.SetActive(false);
        BG.SetActive(false);
        BB.SetActive(false);
        IT.SetActive(false);
        IN.SetActive(false);
        IL.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickCointoItem()
    {

        if (opened == false)
        {

            OpenShop();

        }

        if (opened == true)
        {
            
            CloseShop();
        }

        Time.fixedDeltaTime = 0.02F * Time.timeScale;

    }

    public void OpenShop()
    {
        Debug.Log("열림!");
        opened = true;
        Time.timeScale = 0;
        NB.SetActive(true);
        BG.SetActive(true);
        BB.SetActive(true);
        IT.SetActive(true);
    }
    public void CloseShop()
    {
        opened = false;
        Time.timeScale = 1.0f;

        NB.SetActive(false);
        BG.SetActive(false);
        BB.SetActive(false);
        IT.SetActive(false);
        
    }


    public void OnClickNosework()
    {
        IN.SetActive(true);
        IL.SetActive(false);
    }

    public void OnClickLantern()
    {
        IN.SetActive(false);
        IL.SetActive(true);
    }
}