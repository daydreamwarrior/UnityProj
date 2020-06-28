using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BClicks : MonoBehaviour
{
    bool CointoItemclicked = false;

    GameObject TempLB, TempNB, TempBG;
   
    // Start is called before the first frame update
    void Start()
    {
        TempBG = GameObject.FindWithTag("UIBG");
        TempLB = GameObject.FindWithTag("LanternB");
        TempNB = GameObject.FindWithTag("NoseworkB");

        TempLB.SetActive(false);
        TempNB.SetActive(false);
        TempBG.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (CointoItemclicked == true)
        {
            TempLB.SetActive(true);
            TempNB.SetActive(true);
            TempBG.SetActive(true);
        }
        else
        {
            TempLB.SetActive(false);
            TempNB.SetActive(false);
            TempBG.SetActive(false);
        }
    }

    public void CointoItemButton()
    {
        if (CointoItemclicked == false)
        {
            CointoItemclicked = true;
            Time.timeScale = 0;
            
        }

        else
        {
            CointoItemclicked = false;
            Time.timeScale = 1.0f;
        }

        Time.fixedDeltaTime = 0.02F * Time.timeScale;

    }
}
