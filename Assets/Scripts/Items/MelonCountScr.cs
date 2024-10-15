using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MelonCountScr : MonoBehaviour
{
    public GameObject obj;
    private TMP_Text txt;
    public int melonCount;

    private void Start()
    {
        txt = obj.GetComponent<TMP_Text>();
        melonCount = 0;
    }
    private void Update()
    {
        txt.text = ("x  " + melonCount);
    }
}
