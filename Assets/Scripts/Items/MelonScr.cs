using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonScr : MonoBehaviour
{
    GameObject a;
    MelonCountScr b;
    Animation c;
    IEnumerator d;
    BoxCollider2D e;
    void Start()
    {
        a = GameObject.Find("MelonCounter");
        b = a.GetComponent<MelonCountScr>();
        c = GetComponent<Animation>();
        e = GetComponent<BoxCollider2D>();

        c.Play("m_melon");
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            e.gameObject.SetActive(false);
            b.melonCount++;
            c.Play("m_col");
            new WaitForSeconds(0.717f);
            Destroy(gameObject);
        }
    }
}
