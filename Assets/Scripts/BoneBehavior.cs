using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Q스킬:뼈다귀 부메랑.
public class BoneBehavior : MonoBehaviour
{
    GameObject BAni;
    public Image BoneSkill;
    public float BoneSpeed = 20.0f;
    private Quaternion Right = Quaternion.identity;
    Vector3 InitPos = new Vector3 (0f, -5f, 0f);
    Vector3 MousePos = new Vector3();
    bool Skilled = false;
    // Start is
    //called before the first frame update
    
    void Start()
    {
        BoneSkill.fillAmount = 1.0f;
        //Boneffect.SetActive(false);
        BAni = GameObject.FindGameObjectWithTag("BoneEffect");
        BAni.GetComponent<Animation>().wrapMode=WrapMode.Once;
        Skilled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                BoneSkill.fillAmount = 0.0f;
                MousePos = Input.mousePosition;
                Skilled = true;

            }

        }

        if (Skilled == true)
        {   
            var worldPos = Camera.main.ScreenToWorldPoint(MousePos);
            transform.position = Vector3.MoveTowards(transform.position, worldPos, BoneSpeed * Time.deltaTime);
            transform.Rotate(new Vector3(0,0,90 * Time.deltaTime));
            if (transform.position == worldPos)
            {
                BAni.transform.position = new Vector3(MousePos.x, MousePos.y, MousePos.y);
                BAni.GetComponent<Animator>().SetTrigger("Bplay");
                Invoke("SetInitPos", 1);
                Skilled = false;


            }
        }
        if (BoneSkill.fillAmount < 1.0f)
        {
            BoneSkill.fillAmount += 0.007f;
        }
    }
    void SetInitPos()
    {
        BAni.GetComponent<Animator>().SetTrigger("BPlayEnd");
        transform.position = InitPos;
        BAni.transform.position = new Vector3(InitPos.x, InitPos.y, InitPos.z);
    }
    

}
