using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotsatNoseWorkBall : MonoBehaviour
{
    private IEnumerator co;
    Vector3 MousePos = new Vector3();
    public float Shootspeed = 10.0f;
    Vector3 MovePos = new Vector3(1, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        co = ShootTransform();

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
                transform.Translate(new Vector3(1, 1, 0) * Shootspeed * Time.deltaTime);
            }
            if (transform.position.x < 0)
            {
                transform.Translate(new Vector3(-1, 1, 0) * Shootspeed * Time.deltaTime);
            }
            yield return new WaitForSeconds(1);
        }
    }
}


