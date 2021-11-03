using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2f;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GetController();
    }

    void GetController()
    {
        Vector3 moveDir = new Vector3();
        if (Input.GetKey(KeyCode.LeftArrow))
            moveDir += new Vector3(-1, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            moveDir += new Vector3(1, 0, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            moveDir += new Vector3(0,-1, 0);
        if (Input.GetKey(KeyCode.UpArrow))
            moveDir += new Vector3(0, 1, 0);

        transform.position += moveDir.normalized * speed * Time.deltaTime;
        anim.SetInteger("HorizSpeed", (int)moveDir.x);
        anim.SetInteger("VerticalSpeed", (int)moveDir.y);
    }
}
