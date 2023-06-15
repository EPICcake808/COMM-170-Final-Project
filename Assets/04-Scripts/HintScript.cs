using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintScript : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    private int hintCount;
    void Update()
    {
        hintCount = PlayerPrefs.GetInt("Hints");
        if(hintCount < 6)
        {
            text.text = "Hints: " + hintCount;
        }
        else
        {
            text.text = "Hints: " + hintCount + "<br>All Hints Found";
        }
    }
}
