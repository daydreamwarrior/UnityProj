﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class E2Behav1 : MonoBehaviour
{
    public GameObject Gethpbar;
    Image hpbar;
    Vector3 PlayerPos = new Vector3(0f, -4f, 0f);
    public float MaxHp = 100;
    public float Espeed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        Gethpbar = GameObject.FindGameObjectWithTag("hpe2");
        hpbar = Gethpbar.GetComponent<Image>();

        if (transform.position.x < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, PlayerPos, Espeed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Shots")
        {
            Debug.Log("부딪");
            float HP = 60f;
            hpbar.fillAmount = HP / 100f;

        }
    }
}