using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamFollow : MonoBehaviour
{

    public GameObject parent;
    public Vector3 des;
    float y;
    float x;

    void FixedUpdate()
    {

        x = parent.transform.position.x;
        y = parent.transform.position.y;

        des = new Vector3(x, y, 0);

        transform.position = des;

    }

}
