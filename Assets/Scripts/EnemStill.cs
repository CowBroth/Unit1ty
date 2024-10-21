using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemStill : MonoBehaviour
{
    PublicScr pubScr;
    Animator anim;
    GameObject plr;
    void Start()
    {
        pubScr = gameObject.AddComponent<PublicScr>();
        anim = gameObject.GetComponent<Animator>();
        plr = GameObject.Find("Player");
    }
    void Update()
    {
        if (plr.transform.position.x < gameObject.transform.position.x)
        {
            pubScr.FlipObject(true);
        }
        else
        {
            pubScr.FlipObject(false);
        }
    }
}
