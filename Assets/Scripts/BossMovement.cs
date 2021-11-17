using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
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
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetFloat("Speed", 0.8f);
            anim.SetFloat("yDir", 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetFloat("Speed", 0.4f);
            anim.SetFloat("yDir", 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
            anim.SetFloat("yDir", -1f);
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetFloat("yDir", 0.51f);
            anim.SetTrigger("IsJumping");
        }
    }
}
