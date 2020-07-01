using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lantern : MonoBehaviour
{
    public ParticleSystem LightsPart;
    public Image LanSkill;
    float LanSpeed = 3.0f;
    Vector3 LanternPos = new Vector3(0, -2, 0);
    bool skilled = false;
    // Start is called before the first frame update
    void Start()
    {
        LanSkill.fillAmount = 1.0f;
        LightsPart.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            LanSkill.fillAmount = 0.0f;
            Invoke("PlayParticle", 1);
            skilled = true;
        }
        if (skilled)
        {
            transform.position = Vector3.MoveTowards(transform.position, LanternPos, LanSpeed * Time.deltaTime);
            
        }
        if (skilled == false)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            transform.position = new Vector3(0, -5, 0);
        }

        if (LanSkill.fillAmount < 1.0f)
        {
            LanSkill.fillAmount += 0.003f;
        }
    }
    void PlayParticle()
    {
        transform.localScale = new Vector3(2f, 2f, 2f);
        LightsPart.Play();
        skilled = false;
        
    }
    
}
