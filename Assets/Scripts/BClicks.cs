using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BClicks : MonoBehaviour
{
    int opened = 0;

    GameObject NB, BG, IT, LB,IN,SP;

    // Start is called before the first frame update
    void Start()
    {
        BG = GameObject.FindWithTag("UIBG");
        NB = GameObject.FindWithTag("NoseworkB");
        LB = GameObject.FindWithTag("LanternB");
        IT = GameObject.FindWithTag("InfoT");
        IN = GameObject.FindWithTag("InfoN");
        SP = GameObject.FindWithTag("Space");


        BG.SetActive(false);
        NB.SetActive(false);
        LB.SetActive(false);
        IT.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickCointoItem()
    {

        opened++;
        Debug.Log(opened % 2);
        if (opened % 2 == 1)
        {

            OpenShop();

        }

        if (opened % 2 == 0)
        {

            CloseShop();
        }

        Time.fixedDeltaTime = 0.02F * Time.timeScale;

    }

    public void OpenShop()
    {
        Time.timeScale = 0;
        BG.SetActive(true);
        NB.SetActive(true);
        LB.SetActive(true);
        IT.SetActive(true);
    }

    public void CloseShop()
    {
        Time.timeScale = 1.0f;
        BG.SetActive(false);
        NB.SetActive(false);
        LB.SetActive(false);
        IT.SetActive(false);
        IN.SetActive(false);
        SP.SetActive(false);


    }

}