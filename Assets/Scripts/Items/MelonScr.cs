using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonScr : MonoBehaviour
{
    public GameObject melon;
    MelonCountScr count;
    private void Start()
    {
        melon.GetComponent<MelonCountScr>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            melon.melonCount++;
            print("Melons: " + melon.melonCount);
            Destroy(gameObject);
        }
    }
}
