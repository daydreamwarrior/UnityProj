using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour
{
    public ParticleSystem LightsPart;
    float LanSpeed = 3.0f;
    Vector3 LanternPos = new Vector3(0, -2, 0);
    bool skilled = false;
    // Start is called before the first frame update
    void Start()
    {
        LightsPart.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            LightsPart.Play();
            skilled = true;
        }
        if (skilled)
        {
            transform.position = Vector3.MoveTowards(transform.position, LanternPos, LanSpeed * Time.deltaTime);
            //transform.localScale = new Vector3(5F, 5F, 5F);
        }
    }
    
}
