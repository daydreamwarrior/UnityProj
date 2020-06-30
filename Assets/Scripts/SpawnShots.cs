using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShots : MonoBehaviour
{
    public GameObject Shots;
    private IEnumerator co;
    // Start is called before the first frame update
    void Start()
    {
        co = InstantiateShots();
        StartCoroutine(co);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator InstantiateShots()
    {
        while (true)
        {
            Debug.Log("코루틴~");
            if (SpawnNoseworkBall.NumofNoseWorkBalls == 1)
            {
                Instantiate(Shots, new Vector3(SpawnNoseworkBall.Poses[0].x, SpawnNoseworkBall.Poses[0].y, 0), Quaternion.identity);
                
            }
            if (SpawnNoseworkBall.NumofNoseWorkBalls == 2)
            {
                Instantiate(Shots, new Vector3(SpawnNoseworkBall.Poses[1].x, SpawnNoseworkBall.Poses[1].y, 0), Quaternion.identity);
                
            }
            if (SpawnNoseworkBall.NumofNoseWorkBalls == 3)
            {
                Instantiate(Shots, new Vector3(SpawnNoseworkBall.Poses[2].x, SpawnNoseworkBall.Poses[2].y, 0), Quaternion.identity);
            }
            yield return new WaitForSeconds(3);
        }
    }
}
