using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class walltext : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    // Update is called once per frame
    void Update()
    {
        if(MainManager.Instance.pickHappened)
        {
            text.text = "";
        }
    }
}
