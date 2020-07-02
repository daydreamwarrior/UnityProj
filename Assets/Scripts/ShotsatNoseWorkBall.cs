using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotsatNoseWorkBall : MonoBehaviour
{
    private IEnumerator co, co2, co3;
    public float Shootspeed = 3.0f;
    Vector3 MovePos = new Vector3(1, 1, 0);
    Vector3 InitPos;
    // Start is called before the first frame update
    void Start()
    {
        co = Shoot1();
        co2 = Shoot2();
        co3 = Shoot3();

        if (transform.position.x > 0)
        {
            Vector3 scale = transform.localScale;
            scale.y *= -1;
            transform.localScale = scale;
            Vector3 tempPos = transform.position;
            tempPos.x += 1.0f;
            tempPos.y += 1.0f;
            transform.position = tempPos;
        }

    }
    void Scale()
    {
        if (transform.position.x > 0)
        {
            Vector3 scale = transform.localScale;
            scale.y *= -1;
            transform.localScale = scale;
            Vector3 tempPos = transform.position;
            tempPos.x += 1.0f;
            tempPos.y += 1.0f;
            transform.position = tempPos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnShots.first)
        {
            StartCoroutine(co);
        }
        

        if (SpawnShots.second)
        {
            StartCoroutine(co2);

        }
        if (SpawnShots.third)
        {
            StartCoroutine(co3);
        }
    }

    IEnumerator Shoot1()
    {
        
        while (true)
        {
            if (SpawnShots.shotlist[0].transform.position.x > 0)
            {
                InitPos = SpawnNoseworkBall.Poses[0];
                SpawnShots.shotlist[0].transform.Translate(new Vector3(1, 1, 0) * Shootspeed * 0.02f);
            }
            if (SpawnShots.shotlist[0].transform.position.x < 0)
            {
                SpawnShots.shotlist[0].transform.Translate(new Vector3(-1, 1, 0) * Shootspeed * 0.02f);
            }

            yield return new WaitForSeconds(3);
            StopCoroutine(co);
        }
    }
    IEnumerator Shoot2()
    {
        while (true)
        {
            InitPos = SpawnNoseworkBall.Poses[1];
            if (SpawnShots.shotlist[1].transform.position.x > 0)
            {
                SpawnShots.shotlist[1].transform.Translate(new Vector3(1, 1, 0) * Shootspeed * 0.02f);
            }
            if (SpawnShots.shotlist[1].transform.position.x < 0)
            {
                SpawnShots.shotlist[1].transform.Translate(new Vector3(-1, 1, 0) * Shootspeed * 0.02f);
            }
            yield return new WaitForSeconds(3);
            StopCoroutine(co2);
        }
    }
    IEnumerator Shoot3()
    {
        while (true)
        {
            if (SpawnShots.shotlist[2].transform.position.x > 0)
            {
                SpawnShots.shotlist[2].transform.Translate(new Vector3(1, 1, 0) * Shootspeed * 0.02f);
            }
            if (SpawnShots.shotlist[2].transform.position.x < 0)
            {
                SpawnShots.shotlist[2].transform.Translate(new Vector3(-1, 1, 0) * Shootspeed * 0.02f);
            }
            yield return new WaitForSeconds(3);
            StopCoroutine(co3);
        }
    }

    private void OnBecameInvisible()
    {
        if (this.gameObject == SpawnShots.shotlist[0])
        {
            SpawnShots.shotlist[0].transform.position = SpawnNoseworkBall.Poses[0];
        }
        if (this.gameObject == SpawnShots.shotlist[1])
        {
            SpawnShots.shotlist[1].transform.position = SpawnNoseworkBall.Poses[1];
        }
        if (this.gameObject == SpawnShots.shotlist[2])
        {
            SpawnShots.shotlist[2].transform.position = SpawnNoseworkBall.Poses[2];
        }

    }
}

