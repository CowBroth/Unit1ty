using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicScr : MonoBehaviour
{

    SpriteRenderer sr;

    void Start()
    {
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

    public void SpriteLook()
    {

        transform.LookAt(Camera.main.transform.position);

    }

    

}
