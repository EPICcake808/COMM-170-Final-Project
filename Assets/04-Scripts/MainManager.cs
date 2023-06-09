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
    public bool cyle;
    public bool summon;

    public bool lelliotPick;
    public bool belliotPick;
    public bool jakePick;
    public bool saunderPick;
    public bool cylePick;

    public bool pickHappened;
    public bool correctPick;
    public string videoname;

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

        PlayerPrefs.SetFloat("timerCount", 600);
        currentHints = PlayerPrefs.GetInt(hintKey);
    }

    void Start()
    {
        PlayerPrefs.DeleteAll();
        SetHints(0);

        lelliot = false;
        belliot = false;
        jake = false;
        saunder = false;
        cyle = false;
        summon = false;

        lelliotPick = false;
        belliotPick = false;
        jakePick = false;
        saunderPick = false;
        cylePick = false;

        pickHappened = false;
        correctPick = false;
        videoname = "";
    }

    void Update()
    {
        
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

    public void cyleActivate()
    {
        int hints = PlayerPrefs.GetInt(hintKey);
        if(cyle == false)
        {
            hints += 1;
            SetHints(hints);
            cyle = true;
            Debug.Log("cyle hint activated");
            Debug.Log("Hints: " + PlayerPrefs.GetInt(hintKey));
        }
    }

    public void saunderSummon()
    {
        int hints = PlayerPrefs.GetInt(hintKey);
        if(summon == false)
        {
            hints += 1;
            SetHints(hints);
            summon = true;
            Debug.Log("summon hint activated");
            Debug.Log("Hints: " + PlayerPrefs.GetInt(hintKey));
        }
    }
}
