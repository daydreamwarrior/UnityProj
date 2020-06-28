using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Q스킬:뼈다귀 부메랑.
public class BoneBehavior : MonoBehaviour
{
    GameObject Boneffect;
    public float BoneSpeed = 3.0f;
    Vector3 InitPos = new Vector3 (0f, -4f, 0f);
    Vector3 MousePos = new Vector3();
    bool Skilled = false;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = InitPos;
        Boneffect = GameObject.FindWithTag("BoneEffect");
        Boneffect.SetActive(false);
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
            
            if (transform.position == worldPos)
            {
                StartCoroutine("BoneAttack");
                Skilled = false;
            }
        }

    }

    IEnumerator BoneAttack()
    {
        Boneffect.SetActive(true);
        yield return new WaitForSeconds(1);
        transform.position = InitPos;
        

    }


}
