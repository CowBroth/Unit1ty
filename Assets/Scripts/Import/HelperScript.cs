using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperScript : MonoBehaviour
{
    LayerMask floorMask;
    SpriteRenderer sr;
    Vector3 offset;
    void Start()
    {
        floorMask = LayerMask.GetMask("Floor");
        sr = gameObject.GetComponent<SpriteRenderer>();
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
    public bool GroundRaycast()
    {

        bool boolean = false;
        float length = 0.25f;
        Color color = Color.white;

        RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector2.down, length, floorMask);

        if (ray.collider != null)
        {
            boolean = true;
            color = Color.green;
        }

        Debug.DrawRay(transform.position, Vector2.down * length, color);

        return boolean;

    }

}
