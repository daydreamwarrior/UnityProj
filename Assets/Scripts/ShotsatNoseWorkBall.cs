using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotsatNoseWorkBall : MonoBehaviour
{
    private IEnumerator co;
    public float Shootspeed = 10.0f;
    Vector3 MovePos = new Vector3(1, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        co = ShootTransform();
        if (transform.position.x > 0)
        {
            Vector3 scale = transform.localScale;
            scale.y *= -1;
            transform.localScale = scale;
            Vector3 tempPos = transform.position;
            tempPos.x +=1.0f;
            tempPos.y += 1.0f;
            transform.position = tempPos;
        }

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(co);     
    }

    IEnumerator ShootTransform()
    {
        while (true)
        {
            if (transform.position.x > 0)
            {
                transform.Translate(new Vector3(1, 1, 0) * Shootspeed * 0.02f);
            }
            if (transform.position.x < 0)
            {
                transform.Translate(new Vector3(-1, 1, 0) * Shootspeed * 0.02f);
            }
            yield return new WaitForSeconds(1);
        }
    }
}


