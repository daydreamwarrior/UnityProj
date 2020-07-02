using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHpCoinManager : MonoBehaviour
{
    public Image PlayerHpImage;
    public Text TextPlayerMoney;
    public static float PlayerHp;
    public float CurHp = 100;
    public static int PlayerMoney=0;
    
    // Start is called before the first frame update
    private void Awake()
    {
        
    }

    void Start()
    {
        PlayerHp = CurHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHp <= 1)
        {
            Debug.Log("게임오버");
            SceneManager.LoadScene("GameOver");
        }
        TextPlayerMoney.text = PlayerMoney.ToString();
        PlayerHpImage.fillAmount = PlayerHp / CurHp;
    }
}
