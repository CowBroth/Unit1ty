using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemDie : MonoBehaviour
{
    public GameObject enem;
    private void OnTriggerEnter2D(Collider2D col)
    { 
        if (col.gameObject.tag == "5Head")
        {
            gameObject.GetComponentInParent<Rigidbody2D>().AddForce(new Vector3(0, 20, 0), ForceMode2D.Impulse);
            enem = col.gameObject;
            enem.GetComponentInParent<NemScr>().Die();
        }
        if (col.gameObject.tag == "6Head")
        {
            gameObject.GetComponentInParent<Rigidbody2D>().AddForce(new Vector3(0, 37.5f, 0), ForceMode2D.Impulse);
            enem = col.gameObject;
            enem.GetComponentInParent<EnemStill>().Die();
        }
    }
}
