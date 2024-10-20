using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerScr : MonoBehaviour
{

    Rigidbody2D rb;
    SpriteRenderer sr;
    Transform tr;
    PublicScr pubScr;
    CommonRay cmnRay;

    public Vector3 jumpHgh = new Vector3(0, 0, 0);
    public bool jump;
    public bool fall;
    public bool walk;
    public bool run;
    float op;
    float np;

    public int melonCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        pubScr = gameObject.AddComponent<PublicScr>();
        cmnRay = gameObject.AddComponent<CommonRay>();
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        np = transform.position.y;
        PlrWalk();
        PlrRun();
        PlrJump();
        Checks();
        op = transform.position.y;
    }

    void PlrWalk()
    {

        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-3, rb.velocity.y);
            run = false;
            walk = true;
        }
        else if (Input.GetKey("right"))
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
            run = false;
            walk = true;
        }
        else if (rb.velocityX < 1.5 || rb.velocityX > -1.5)
        {
            walk = false;
        }
        if (Input.GetKey("left") && cmnRay.grnd)
        {
            pubScr.FlipObject(true);
        }
        if (Input.GetKey("right") && cmnRay.grnd)
        {
            pubScr.FlipObject(false);
        }
    }

    void PlrRun()
    {

        if (Input.GetKey("x") && Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-6, rb.velocity.y);
            walk = false;
            run = true;
        }
        else if (Input.GetKey("x") && Input.GetKey("right"))
        {
            rb.velocity = new Vector2(6, rb.velocity.y);
            walk = false;
            run = true;
        }
        else if (rb.velocityX < 6 || rb.velocityX > -6)
        {
            run = false;
        }
    }

    void PlrJump()
    { 
        if (Input.GetKeyDown("z") && cmnRay.grnd == true)
        {
            rb.AddForce(jumpHgh, ForceMode2D.Impulse);
        }
        if (np > op)
        {
            jump = true;
            fall = false;
        }
        else
        {
            fall = true;
            jump = false;
        }
    }
    void Checks()
    {
        if (cmnRay.grnd)
        {
            jump = false;
            fall = false;
        }
        else
        {
            walk = false;
            run = false;
        }
    }
}