using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NemScr : MonoBehaviour
{
    CommonRay cmnRay;
    PublicScr pubScr;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        cmnRay = gameObject.AddComponent<CommonRay>();
        pubScr = gameObject.AddComponent<PublicScr>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cmnRay.nemT)
        {
            pubScr.FlipObject(true);
            rb.velocity = new Vector2(-2f, rb.velocity.y);
        }
        if (!cmnRay.nemT)
        {
            pubScr.FlipObject(false);
            rb.velocity = new Vector2(2f, rb.velocity.y);
        }
    }
}
