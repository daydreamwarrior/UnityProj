using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    Vector3 NearPlayer = new Vector3(1.5f, 1.5f, 0);
    float Espeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHpCoinManager.PlayerHp <= 30)
        {
            transform.position = Vector3.MoveTowards(transform.position, NearPlayer, Espeed * Time.deltaTime);
            PlayerHpCoinManager.PlayerHp -= 1;
        }
    }
}
