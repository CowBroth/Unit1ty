using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlrAnimScr : MonoBehaviour
{

    Animator anim;
    PlayerScr plr;
    CommonRay cmnRay;

    void Start()
    {
        
        anim = GetComponent<Animator>();
        plr = GetComponent<PlayerScr>();
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
    }

    private void Walk()
    { 

        if (plr.walk && cmnRay.grnd == true)
        {
            anim.SetBool("Run", false);
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }

    }

    private void Run()
    {

        if (plr.run && cmnRay.grnd == true)
        {
            anim.SetBool("Walk", false);
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }

    }

    private void Jump()
    {

    }
    private void Fall()
    {

    }

}
