using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintScript : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    void Update()
    {
        text.text = "Hints: " + PlayerPrefs.GetInt("Hints");
    }
}
