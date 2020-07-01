using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShots : MonoBehaviour
{
    public GameObject Shots;
    public static bool first, second, third=false;
    //public static List<GameObject> Shotslist = new List<GameObject>();
    public static GameObject[] shotlist=new GameObject[3];
    Vector3 InitPos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (first == false && SpawnNoseworkBall.NumofNoseWorkBalls == 1)
        {
            GameObject _obj=Instantiate(Shots, new Vector3(SpawnNoseworkBall.Poses[0].x, SpawnNoseworkBall.Poses[0].y, 0), Quaternion.identity);
            shotlist[0] = _obj;
            first = true;
        }
        if (second == false && SpawnNoseworkBall.NumofNoseWorkBalls == 2)
        {
            GameObject _obj = Instantiate(Shots, new Vector3(SpawnNoseworkBall.Poses[1].x, SpawnNoseworkBall.Poses[1].y, 0), Quaternion.identity);
            shotlist[1] = _obj;
            second = true;
        }
        if (third == false && SpawnNoseworkBall.NumofNoseWorkBalls == 3)
        {
            GameObject _obj = Instantiate(Shots, new Vector3(SpawnNoseworkBall.Poses[2].x, SpawnNoseworkBall.Poses[2].y, 0), Quaternion.identity);
            shotlist[2] = _obj;
            third = true;
        }
    }
    
}
