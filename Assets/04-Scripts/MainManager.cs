using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    string hintKey = "Hints";

    public bool lelliot;
    public bool belliot;
    public bool jake;
    public bool saunder;

    public int currentHints { get; set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        currentHints = PlayerPrefs.GetInt(hintKey);
    }

    void Start()
    {
        SetHints(0);

        lelliot = false;
        belliot = false;
        jake = false;
        saunder = false;
    }
    public void SetHints(int hintcount)
    {
        PlayerPrefs.SetInt(hintKey, hintcount);
    }

    public void lelliotActivate()
    {
        int hints = PlayerPrefs.GetInt(hintKey);
        if(lelliot == false)
        {
            hints += 1;
            SetHints(hints);
            lelliot = true;
            Debug.Log("lelliot hint activated");
            Debug.Log("Hints: " + PlayerPrefs.GetInt(hintKey));
        }
    }

    public void belliotActivate()
    {
        int hints = PlayerPrefs.GetInt(hintKey);
        if (belliot == false)
        {
            hints += 1;
            SetHints(hints);
            belliot = true;
            Debug.Log("belliot hint activated");
            Debug.Log("Hints: " + PlayerPrefs.GetInt(hintKey));
        }
    }

    public void jakeActivate()
    {
        int hints = PlayerPrefs.GetInt(hintKey);
        if (jake == false)
        {
            hints += 1;
            SetHints(hints);
            jake = true;
            Debug.Log("jake hint activated");
            Debug.Log("Hints: " + PlayerPrefs.GetInt(hintKey));
        }
    }

    public void saunderActivate()
    {
        int hints = PlayerPrefs.GetInt(hintKey);
        if (saunder == false)
        {
            hints += 1;
            SetHints(hints);
            saunder = true;
            Debug.Log("saunder hint activated");
            Debug.Log("Hints: " + PlayerPrefs.GetInt(hintKey));
        }
    }
}
