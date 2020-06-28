using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class E2Hpbar : MonoBehaviour
{
    [SerializeField] GameObject goprefab = null;
    List<Transform> objlist = new List<Transform>();
    List<GameObject> barlist = new List<GameObject>();
    Camera m_cam = null;

    //public Slider E2HpSlider;
    //float CurrentPos = 0.0f;
    //float MaxHp = 100.0f;
    // Start is called before the first frame update
    //private Enemy2Behavior E2;
    void Start()
    {
        m_cam = Camera.main;
        GameObject[] t_obj = GameObject.FindGameObjectsWithTag("Enemy2");
        for(int i = 0; i < t_obj.Length; i++)
        {
            objlist.Add(t_obj[i].transform);
            GameObject t_hpbar = Instantiate(goprefab, t_obj[i].transform.position, Quaternion.identity, transform);
            barlist.Add(t_hpbar);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < objlist.Count; i++)
        {
            barlist[i].transform.position = m_cam.WorldToScreenPoint(objlist[i].position + new Vector3(0, 1.0f, 0));
        }
        //E2HpSlider.value = (float)E2.E2CurHp/MaxHp;
    }
}
