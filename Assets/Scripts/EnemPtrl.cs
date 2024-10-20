using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemPtrl : MonoBehaviour
{
    public bool trn = false;
    LayerMask floor;
    void Start()
    {
        floor = LayerMask.GetMask("Floor");
    }
    void Update()
    {
        NemGrndRay();
    }
    public bool NemGrndRay()
    {
        RaycastHit2D eRay0 = Physics2D.Raycast(transform.position + new Vector3 (-0.5f, 0, 0), Vector2.down, 1, floor);
        RaycastHit2D eRay1 = Physics2D.Raycast(transform.position + new Vector3(0.5f, 0, 0), Vector2.down, 1, floor);

        if (eRay0.collider == null)
        {
            trn = false;
        }
        if (eRay1.collider == null)
        {
            trn = true;
        }
        Debug.DrawRay(transform.position + new Vector3(-0.5f, 0, 0), Vector2.down * 1);
        Debug.DrawRay(transform.position + new Vector3(0.5f, 0, 0), Vector2.down * 1);
        return trn;
    }
}
