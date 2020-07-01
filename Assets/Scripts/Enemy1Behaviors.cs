using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy1Behaviors : MonoBehaviour
{

    public float Espeed = 1.0f;
    public int E1Hp = 100;
    Vector3 PlayerPos = new Vector3 (0f, -4f, 0f);
    float randX, randY;
    int randMinusPlus;
    static bool PrefabDead = false;

    // Start is called before the first frame update
    void Start()
    {
        SetInit();
    }
    void SetInit()
    {
        if (transform.position.x < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }

    // Update is called once per frame
    void Update(){
        transform.position = Vector3.MoveTowards(transform.position, PlayerPos, Espeed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Bone"|| target.gameObject.tag == "Shots")
        {
            Invoke("TransformNewPos",1);
        }

        if (target.gameObject.tag == "Player")
        {
            Invoke("TransformNewPos", 1);
        }

    }
    void TransformNewPos()
    {
        Destroy(this.gameObject);
        PrefabDead = true;

      //randMinusPlus = Random.Range(0, 2);

        //  if (randMinusPlus == 0)//왼쪽(마이너스)
        //  {
        //      randX = Random.Range(-25f, -5f);
        //      randY = Random.Range(-3f, 10f);
        //      Vector3 scale = transform.localScale;
        //      scale.x *= -1;
        //      transform.localScale = scale;
        //      transform.position = new Vector3(randX, randY, 2);
        //      Debug.Log("새로옮겨짐"+randX);
        //  }
        //  else
        //  {
        //      randX = Random.Range(5f, 25f);
        //      randY = Random.Range(-3f, 10f);
        //      transform.position = new Vector3(randX,randY,2);
        //      Debug.Log("새로옮겨짐" + randX);
        //  }

    }
}
