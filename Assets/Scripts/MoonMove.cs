using UnityEngine;
using System.Collections;

public class MoonMove : MonoBehaviour
{ 
    Vector3 MoonStart; 
    Vector3 MoonEnd; 
    float time;
    float vx; 
    float vy; 
    float vz;
    bool Move = true;
    float Speed;
    float GameTime = 50.0f;
    void Start () {

        time = Time.time;
        MoonStart = new Vector3(-11,-4,0);
        MoonEnd = new Vector3(11, -4, 0);
        vx = (MoonEnd.x - MoonStart.x) / 2f; 
        vz = (MoonEnd.z - MoonStart.z) / 2f; 
        vy = (MoonEnd.y - MoonStart.y + 2 * 9.8f/2f); 
    } 
    // Update is called once per frame 
    void Update () {
        if (Move)
        {
            Speed = (Time.time - time) / GameTime;
            float sx = MoonStart.x + vx * Speed;
            float sy = MoonStart.y + vy * Speed - 0.5f * 9.8f * Speed * Speed;
            float sz = MoonStart.z + vz * Speed;
            transform.position = new Vector3(sx, sy, sz);
        }
        
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Under")
        {
            Move = false;
            //게임 종료 씬으로 넘어가도록
        }
    }
} 


