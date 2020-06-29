using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEditorInternal;
using UnityEngine;

public class SpawnNoseworkBall : MonoBehaviour
{
    public GameObject NoseWorkBall;
    Vector3 MousePos = new Vector3();
    public static Vector3[] Poses=new Vector3[3];
    public static int NumofNoseWorkBalls = 0;

    // Start is called before the first frame update
    void Start()
    {
        NoseWorkBall.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MousePos = Input.mousePosition;

            if (NumofNoseWorkBalls < 3)
            {
                if ((MousePos.y > 60 && MousePos.y < 200) && (MousePos.x > 500 && MousePos.x < 780))
                {
                    NoseWorkBall.GetComponent<SpriteRenderer>().enabled = true;
                    var worldPos = Camera.main.ScreenToWorldPoint(MousePos);
                    Instantiate(NoseWorkBall, new Vector3(worldPos.x, worldPos.y, 0), Quaternion.identity);
                    Poses.SetValue(new Vector3(worldPos.x, worldPos.y, 0), NumofNoseWorkBalls);
                }
                NumofNoseWorkBalls++;
            }
            Debug.Log(NumofNoseWorkBalls);
            Debug.Log("끝");
        }
    }
}
