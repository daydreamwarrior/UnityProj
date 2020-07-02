using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class SpawnNoseworkBall : MonoBehaviour
{
    public GameObject NoseWorkBall;
    public Image WSkill;
    Vector3 MousePos = new Vector3();
    public static Vector3[] Poses=new Vector3[3];
    public static int NumofNoseWorkBalls = 0;
    bool MakeNew = false;

    // Start is called before the first frame update
    void Start()
    {
        NoseWorkBall.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetNoseWork.SetNS==true&&Input.GetMouseButtonDown(0))
        {
            MousePos = Input.mousePosition;

            if (NumofNoseWorkBalls < 3)
            {
                InstBall();
            }
        }

        if (WSkill.fillAmount >= 1.0f && Input.GetKeyDown(KeyCode.W))
        {
            MakeNew = true;
            if (MakeNew&&Input.GetMouseButton(0)) {
                MousePos = Input.mousePosition;
                if (NumofNoseWorkBalls < 3)
                {
                    InstBall();
                }
            }
        }

        if (WSkill.fillAmount < 1.0f)
        {
            WSkill.fillAmount += 0.0005f;
        }
    }
    void InstBall()
    {
        if ((MousePos.y > 60 && MousePos.y < 200) && (MousePos.x > 500 && MousePos.x < 780))
        {
            NoseWorkBall.GetComponent<SpriteRenderer>().enabled = true;
            var worldPos = Camera.main.ScreenToWorldPoint(MousePos);
            Instantiate(NoseWorkBall, new Vector3(worldPos.x, worldPos.y, 0), Quaternion.identity);
            Poses.SetValue(new Vector3(worldPos.x, worldPos.y, 0), NumofNoseWorkBalls);
        }
        GetNoseWork.SetNS = false;
        MakeNew = false;
        NumofNoseWorkBalls++;
        WSkill.fillAmount = 0.0f;
    }
}
