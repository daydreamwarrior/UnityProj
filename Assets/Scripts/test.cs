using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    //public  Gethpbar;
    public Image hpbar;
    float CurHp = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
        hpbar = GetComponent<Image>();
        //GameObject Gethpbar = GameObject.FindGameObjectWithTag("hpe2");
        //hpbar =Gethpbar.GetComponent<Image>();

    }

    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Shots")
        {

            Debug.Log("들어옴");
        }
    }
    public void Damaged()
    {
        //Debug.Log("들어옴");
        hpbar.fillAmount = 40f / CurHp;
        CurHp = CurHp - 40f;
    }
}
