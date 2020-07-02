using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PawBehavior : MonoBehaviour
{
    public Image PawSkill;
    Vector3 InitPos = new Vector3(0f, 7f, 0f);
    float Espeed = 8.0f;
    bool skilled = false;
    // Start is called before the first frame update
    void Start()
    {
        PawSkill.fillAmount = 1.0f;
    }

    void Update()
    {
        if (PawSkill.fillAmount >= 1.0f&& Input.GetKeyDown(KeyCode.R))
        {
            PawSkill.fillAmount = 0.0f;
            skilled = true;
            
        }
        if (skilled)
        {
            transform.Translate(new Vector3(0, -1, 0) * Espeed * Time.deltaTime);
            if (transform.position.y <= -7)
            {
                transform.position = InitPos;
                skilled = false;
            }
        }

        if (PawSkill.fillAmount < 1.0f)
        {
            PawSkill.fillAmount += 0.002f;
        }

    }
}
