using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;
using UnityEngine.UI;

public class E2Behav1 : MonoBehaviour
{
    Vector3 PlayerPos = new Vector3(0f, -4f, 0f);
    Vector3 InitPos = new Vector3(0f, -5f, 0f);
    public float Espeed = 3.0f;
    public float CurHp = 100;
    private float Hp;
    public Image Hpbar;
    float randX, randY;
    int randMinusPlus;
    // Start is called before the first frame update
    void Start()
    {
        SetInit();
    }

    void SetInit()
    {
        Hp = CurHp;
        if (transform.position.x < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
            Hpbar.fillOrigin = (int)Image.OriginHorizontal.Right;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Hp <= 0)
        {
            Invoke("TransformNewPos", 1);
        }
        transform.position = Vector3.MoveTowards(transform.position, PlayerPos, Espeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Shots")
        {
            Hp -= 50.0f;
            Hpbar.fillAmount = Hp/CurHp;

        }
        if (target.gameObject.tag == "Bone")
        {
            Hp -= 30.0f;
            Hpbar.fillAmount = Hp / CurHp;
        }
    }
    void TransformNewPos()
    {
        randMinusPlus = Random.Range(0, 2);
        if (randMinusPlus == 0)//왼쪽(마이너스)
        {
            randX = Random.Range(-25f, -5f);
            randY = Random.Range(-3f, 10f);
            transform.position = new Vector3(randX, randY, 0);
            SetInit();
        }
        else
        {
            randX = Random.Range(5f, 25f);
            randY = Random.Range(-3f, 10f);
            transform.position = new Vector3(randX, randY, 0);
            Hp = CurHp;

        }
    }
}
