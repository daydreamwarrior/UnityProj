using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Behavior : MonoBehaviour
{
    public float Espeed = 3.0f;
    Vector3 PlayerPos = new Vector3(0f, -4f, 0f);

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
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, PlayerPos, Espeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        
    }
}
