using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonScr : MonoBehaviour
{
    GameObject a;
    MelonCountScr b;
    Animator c;
    BoxCollider2D e;
    void Start()
    {
        a = GameObject.Find("MelonCounter");
        b = a.GetComponent<MelonCountScr>();
        c = GetComponent<Animator>();
        e = GetComponent<BoxCollider2D>();
        c.GetBool("Col");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            b.melonCount++;
            e.enabled = false;
            c.SetBool("Col", true);
            StartCoroutine(F());
        }
    }
    void D()
    {
        Destroy(gameObject);
    }
    IEnumerator F()
    {
        yield return new WaitForSeconds(0.717f);
        D();
    }
}
