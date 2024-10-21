using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NemScr : MonoBehaviour
{
    EnemPtrl ptr;
    PublicScr pubScr;
    Rigidbody2D rb;
    Animator anim;
    public bool kill = false;
    public float st, en;
    void Start()
    {
        ptr = gameObject.AddComponent<EnemPtrl>();
        pubScr = gameObject.AddComponent<PublicScr>();
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        anim.GetBool("Kill");
    }
    void Update()
    {
        if (gameObject.transform.position.x == en)
        {
            pubScr.FlipObject(true);
            rb.velocity = new Vector2(-2f, rb.velocity.y);
        }
        if (gameObject.transform.position.x > st)
        {
            pubScr.FlipObject(false);
            rb.velocity = new Vector2(2f, rb.velocity.y);
        }
    }
    public void Die()
    {
        print("kill" + gameObject.name);
        Destroy(rb);
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
