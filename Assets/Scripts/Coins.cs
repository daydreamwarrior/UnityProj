using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    float CoinSpeed = 5.0f;
    Vector3 CurCoinUI = new Vector3(7.5f, 4.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position == CurCoinUI)
        {
            Destroy(this.gameObject);
        }
       
         transform.position = Vector3.MoveTowards(transform.position, CurCoinUI, CoinSpeed * Time.deltaTime);
       
    }
    public void ClickCoin()
    {
        
    }
    
}
