using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;
using UnityEngine.UI;

public class E2Behav1 : MonoBehaviour
{
    Vector3 PlayerPos = new Vector3(0f, -4f, 0f);
    Vector3 InitPos = new Vector3(0f, -5f, 0f);
    public float Espeed = 1.0f;
    public float CurHp = 100;
    private float Hp;
    public Image Hpbar;


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
            TransformNewPos();
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
        if (target.gameObject.tag == "Player")
        {
            PlayerHpCoinManager.PlayerHp -= 33;
            TransformNewPos();
        }
        
    }
    void TransformNewPos()
    {
        Destroy(this.gameObject);
        GameObject.Find("Coins").GetComponent<SpawnCoin>().SetRandomCoins(transform.position);
        GameObject.Find("Enemy2").GetComponent<E2Spawn>().NewPrefabs();
    }
    void OnParticleCollision(GameObject other)
    {
        Debug.Log("파티클 충돌");

    }
}
