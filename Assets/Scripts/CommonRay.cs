using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonRay : MonoBehaviour
{
    public bool grnd;
    LayerMask floor;
    Color color = Color.white;
    void Start()
    {
        floor = LayerMask.GetMask("Floor");
    }
    void Update()
    {
        PlrGrndRay();
    }


    void PlrGrndRay()
    {
        float length = 0.3f;

        RaycastHit2D ray1 = Physics2D.Raycast(transform.position + new Vector3(-0.22f, 0.1f, 0f), Vector2.down, length, floor);
        RaycastHit2D ray2 = Physics2D.Raycast(transform.position + new Vector3(0.22f, 0.1f, 0f), Vector2.down, length, floor);

        if (ray1.collider != null || ray2.collider != null)
        {
            grnd = true;
            color = Color.green;
        }
        else
        {
            grnd = false;
            color = Color.white;
        }

        Debug.DrawRay(transform.position + new Vector3(-0.22f, 0.1f, 0f), Vector2.down * length, color);
        Debug.DrawRay(transform.position + new Vector3(0.22f, 0.1f, 0f), Vector2.down * length, color);
    }
}
