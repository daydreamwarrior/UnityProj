using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShots : MonoBehaviour
{
    public GameObject Shots;
    bool first, second, third=false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SpawnNoseworkBall.NumofNoseWorkBalls==1 &&first==false)
        {
            Instantiate(Shots, new Vector3(SpawnNoseworkBall.Poses[0].x, SpawnNoseworkBall.Poses[0].y, 0), Quaternion.identity);
            first = true;
        }
        if (SpawnNoseworkBall.NumofNoseWorkBalls == 2 && second == false)
        {
            Instantiate(Shots, new Vector3(SpawnNoseworkBall.Poses[1].x, SpawnNoseworkBall.Poses[1].y, 0), Quaternion.identity);
            second = true;
        }
        if (SpawnNoseworkBall.NumofNoseWorkBalls == 3 && third == false)
        {
            Instantiate(Shots, new Vector3(SpawnNoseworkBall.Poses[2].x, SpawnNoseworkBall.Poses[2].y, 0), Quaternion.identity);
            third = true;
        }
    }
}
