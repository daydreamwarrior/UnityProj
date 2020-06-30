using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;
using UnityEngine.UI;

public class E2Behav1 : MonoBehaviour
{
    Vector3 PlayerPos = new Vector3(0f, -4f, 0f);
    public float Espeed = 3.0f;
    public float CurHp = 100;
    private float Hp;
    public Image Hpbar;
    // Start is called before the first frame update
    void Start()
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
        transform.position = Vector3.MoveTowards(transform.position, PlayerPos, Espeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Shots")
        {
            if (Hp <= 0)
            {
                Destroy(this.gameObject);
            }
            Hp -= 50.0f;
            Hpbar.fillAmount = Hp/CurHp;

        }
    }
}
