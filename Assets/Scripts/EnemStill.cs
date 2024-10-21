using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemStill : MonoBehaviour
{
    PublicScr pubScr;
    Animator anim;
    GameObject plr;
    public bool kill = false;
    void Start()
    {
        pubScr = gameObject.AddComponent<PublicScr>();
        anim = gameObject.GetComponent<Animator>();
        plr = GameObject.Find("Player");
        anim.GetBool("Kill");
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
    public void Die()
    {
        print("kill" + gameObject.name);
        Destroy(gameObject.GetComponent<CapsuleCollider2D>());
        Destroy(gameObject.GetComponentInChildren<BoxCollider2D>());
        anim.SetBool("Kill", true);
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.717f);
        ActuallyDie();
    }
    void ActuallyDie()
    {
        Destroy(gameObject);
    }
}
