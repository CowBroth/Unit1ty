using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlrAnimScr : MonoBehaviour
{

    Animator anim;
    PlayerScr plr;
    CommonRay cmnRay;
    Rigidbody2D rb;

    void Start()
    {

        anim = GetComponent<Animator>();
        plr = GetComponent<PlayerScr>();
        rb = GetComponent<Rigidbody2D>();
        cmnRay = gameObject.AddComponent<CommonRay>();

        anim.GetBool("Walk");
        anim.GetBool("Run");
        anim.GetBool("Jump");
        anim.GetBool("Fall");

    }

    void FixedUpdate()
    {
        Walk();
        Run();
        Jump();
        Grnd();
    }

    private void Walk()
    {

        if (rb.velocityX > 1 && rb.velocityX < 6 && cmnRay.grnd)
        {
            anim.SetBool("Run", false);
            anim.SetBool("Walk", true);
        }
    }

    private void Run()
    {

        if (rb.velocityX >= 6 && cmnRay.grnd)
        {
            anim.SetBool("Walk", false);
            anim.SetBool("Run", true);
        }
    }
    private void Jump()
    {
        if (plr.jump && !cmnRay.grnd)
        {
            anim.SetBool("Jump", true);
            anim.SetBool("Fall", false);
        }
        if (plr.fall && !cmnRay.grnd)
        {
            anim.SetBool("Fall", true);
            anim.SetBool("Jump", false);
        }
    }
    private void Grnd()
    {
        if (!cmnRay.grnd)
        {
            anim.SetBool("Walk", false);
            anim.SetBool("Run", false);
        }
        if (cmnRay.grnd)
        {
            anim.SetBool("Jump", false);
            anim.SetBool("Fall", false);
        }
    }
}
