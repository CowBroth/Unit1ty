using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject tgt;
    public Vector3 offset;
    public Vector3 velocity = Vector3.zero;
    public float smooth;

    void LateUpdate()
    {

        Vector3 playerPos = tgt.transform.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, playerPos, ref velocity, smooth); 

    }

}
