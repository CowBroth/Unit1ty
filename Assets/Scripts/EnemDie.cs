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
            gameObject.GetComponentInParent<Rigidbody2D>().AddForce(new Vector3(0, 25, 0), ForceMode2D.Impulse);
            enem = col.gameObject;
            enem.GetComponentInParent<NemScr>().Die();
        }
    }
}
