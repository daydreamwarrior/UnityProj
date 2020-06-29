﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy1Behaviors : MonoBehaviour
{

    public float Espeed = 1.0f;
    public int E1Hp = 100;
    Vector3 PlayerPos = new Vector3 (0f, -4f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x < 0)
       {
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
       }
    }

    // Update is called once per frame
    void Update(){
        transform.position = Vector3.MoveTowards(transform.position, PlayerPos, Espeed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Bone")
        {
            
            if (this.E1Hp <= 0)
            {
                Destroy(this.gameObject);
            }
            this.E1Hp -= 50;
            
        }

        if (target.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }

        if (target.gameObject.tag == "Shots")
        {
            Destroy(this.gameObject);

        }
    }
}
