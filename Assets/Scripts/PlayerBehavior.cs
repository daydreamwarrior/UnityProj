using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    Vector3 Playerpos;
    float delta = 0.05f;
    float speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        Playerpos = transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 v = Playerpos;
        v.y += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
