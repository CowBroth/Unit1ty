using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicScr : MonoBehaviour
{

    SpriteRenderer sr;
    LayerMask floorMask;
    bool boolean = false;

    void Start()
    {

        sr = gameObject.GetComponent<SpriteRenderer>();
        floorMask = LayerMask.GetMask("Floor");

    }

    public void FlipObject(bool flip)
    {

        if (flip == true)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }

    }

    public void SpriteLook()
    {

        transform.LookAt(Camera.main.transform.position);

    }

    public bool GroundRaycast()
    {

        float length = 0.15f;
        Vector3 off1 = new Vector3(-0.22f, 0.1f, 0f);
        Vector3 off2 = new Vector3(0.22f, 0.1f, 0f);
        Color color = Color.white;

        RaycastHit2D ray1 = Physics2D.Raycast(transform.position + off1, Vector2.down, length, floorMask);
        RaycastHit2D ray2 = Physics2D.Raycast(transform.position + off2, Vector2.down, length, floorMask);

        if (ray1.collider || ray2.collider != null)
        {
            boolean = true;
            color = Color.green;
        }
        else
        {
            boolean = false;
        }

        Debug.DrawRay(transform.position + off1, Vector2.down * length, color);
        Debug.DrawRay(transform.position + off2, Vector2.down * length, color);

        return boolean;

    }

}
