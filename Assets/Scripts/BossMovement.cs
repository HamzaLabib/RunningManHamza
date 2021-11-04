using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    //public float speed = 2f;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        GetController();
    }

    void GetController()
    {
        //Vector3 moveDir = new Vector3();
        if (Input.GetKey(KeyCode.LeftArrow))
            anim.SetFloat("Speed", 0.4f);
        if (Input.GetKey(KeyCode.RightArrow))
            anim.SetFloat("Speed", 0.4f);
        if (Input.GetKey(KeyCode.DownArrow))
            anim.SetFloat("yDir", 0.1f);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetFloat("yDir", 0.51f);
            anim.SetTrigger("IsJumping");
        }
            
        /*transform.position += moveDir.normalized * speed * Time.deltaTime;
        anim.SetFloat("Speed", moveDir.x);
        anim.SetFloat("yDir", moveDir.y);*/
    }
}
