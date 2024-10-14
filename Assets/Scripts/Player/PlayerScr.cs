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

        melonCount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {

        np = transform.position.y;
        PlrWalk();
        PlrRun();
        PlrJump();
        op = transform.position.y;

        //check for collision with melon
        
    }

    void PlrWalk()
    {

        if (Input.GetKey("left"))
        {
            pubScr.FlipObject(true);
            rb.velocity = new Vector2(-3, rb.velocity.y);
            walk = true;
        }
        else if (Input.GetKey("right"))
        {
            pubScr.FlipObject(false);
            rb.velocity = new Vector2(3, rb.velocity.y);
            walk = true;
        }
        else
        {
            walk = false;
        }

    }

    void PlrRun()
    {

        if (Input.GetKey("x") && Input.GetKey("left"))
        {
            pubScr.FlipObject(true);
            rb.velocity = new Vector2(-6, rb.velocity.y);
            run = true;
        }
        else if (Input.GetKey("x") && Input.GetKey("right"))
        {
            pubScr.FlipObject(false);
            rb.velocity = new Vector2(6, rb.velocity.y);
            run = true;
        }
        else
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

    }

}
