using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    //public  Gethpbar;
    public Image hpbar;
    int CurHp = 100;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("현재" + CurHp);
        hpbar = GetComponent<Image>();
        //GameObject Gethpbar = GameObject.FindGameObjectWithTag("hpe2");
        //hpbar =Gethpbar.GetComponent<Image>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CurHp = 100;
            Application.Quit();
        }
    }

    
    public void Damaged(float dmg)
    {
        CurHp-=10;
        this.hpbar.fillAmount = CurHp * 0.01f;
        Debug.Log(CurHp);
    }
}
