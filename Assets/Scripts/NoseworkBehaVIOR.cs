using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoseworkBehaVIOR : MonoBehaviour
{
    public GameObject NoseWorkBall;
    Vector3 MousePos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        //NoseWorkBall.SetActive(false);
        NoseWorkBall.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //구매 on -->구매직후 설치
        if (Input.GetMouseButtonDown(0))
        {
            MousePos = Input.mousePosition;
            if ((MousePos.y>60&&MousePos.y < 200) &&(MousePos.x>500&& MousePos.x<780))
            {
                Debug.Log("궤도안!");
                //NoseWorkBall.SetActive(true);
                NoseWorkBall.GetComponent<SpriteRenderer>().enabled = true;
            }

        }
    }
}
