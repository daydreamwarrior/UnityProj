using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject Coin;
    int NumofCoins;
    public static bool Getcoin = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetRandomCoins(Vector3 EnemyPos)
    {
        Vector3 CoinPos = EnemyPos;
        NumofCoins = Random.Range(2, 7);
        Instantiate(Coin, CoinPos, Quaternion.identity);
        PlayerHpCoinManager.PlayerMoney += NumofCoins;
    }
 

}
