using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Q스킬:뼈다귀 부메랑.
public class BoneBehavior : MonoBehaviour
{
    GameObject BAni;
    public float BoneSpeed = 20.0f;
    private Quaternion Right = Quaternion.identity;
    Vector3 InitPos = new Vector3 (0f, -5f, 0f);
    Vector3 MousePos = new Vector3();
    bool Skilled = false;
    // Start is
    //called before the first frame update
    
    void Start()
    {
        //Boneffect.SetActive(false);
        BAni = GameObject.FindGameObjectWithTag("BoneEffect");
        BAni.GetComponent<Animation>().wrapMode=WrapMode.Once;
        Right.eulerAngles = new Vector3(0, 0, 90);
        Skilled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetKeyDown(KeyCode.Q))

            {
                MousePos = Input.mousePosition;
                Skilled = true;

            }

        }

        if (Skilled == true)
        {   
            var worldPos = Camera.main.ScreenToWorldPoint(MousePos);
            transform.position = Vector3.MoveTowards(transform.position, worldPos, BoneSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, Right, Time.deltaTime * 5.0f);

            if (transform.position == worldPos)
            {
                BAni.transform.position = new Vector3(MousePos.x, MousePos.y, MousePos.y);
                BAni.GetComponent<Animator>().SetTrigger("Bplay");
                Invoke("SetInitPos", 2);
                Skilled = false;


            }
        }

    }
    void SetInitPos()
    {
        BAni.GetComponent<Animator>().SetTrigger("BPlayEnd");
        transform.position = InitPos;
        BAni.transform.position = new Vector3(InitPos.x, InitPos.y, InitPos.z);
    }
    

}
