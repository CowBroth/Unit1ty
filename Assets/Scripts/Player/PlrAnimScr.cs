using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlrAnimScr : MonoBehaviour
{
    Animator anim;
    PlayerScr plr;
    PlrDie hit;
    SpriteRenderer sr;
    private void Start()
    {
        anim = GetComponent<Animator>();
        plr = GetComponent<PlayerScr>();
        hit = GetComponent<PlrDie>();
        sr = GetComponent<SpriteRenderer>();

        anim.GetBool("Walk");
        anim.GetBool("Run");
        anim.GetBool("Jump");
        anim.GetBool("Fall");
    }
    private void Update()
    {
        if (plr.walk)
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
        if (plr.run)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
        if (plr.jump)
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
        if (plr.fall)
        {
            anim.SetBool("Fall", true);
        }
        else
        {
            anim.SetBool("Fall", false);
        }
        if (hit.inv)
        {
            sr.color = Color.red;
        }
        else
        {
            sr.color = Color.white;
        }
    }
}
