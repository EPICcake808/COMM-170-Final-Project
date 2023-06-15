using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class NewTimer : MonoBehaviour
{
    [SerializeField] float timeLeft = 600;
    [SerializeField] TMP_Text timerText;
    // Start is called before the first frame update

    void Awake()
    {
        PlayerPrefs.SetFloat("timerCount", 600);
    }

    void Start()
    {

        timeLeft = PlayerPrefs.GetFloat("timerCount");
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Countdown() 
    {
        while(timeLeft >= 0) 
        {
            float minutes = Mathf.FloorToInt(timeLeft / 60);
            float seconds = Mathf.FloorToInt(timeLeft % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            yield return new WaitForSeconds(1);
            timeLeft--;
            PlayerPrefs.SetFloat("timerCount", timeLeft);
            //Debug.Log("Timer: " + PlayerPrefs.GetFloat("timerCount"));
        } 

        SceneManager.LoadScene(sceneName: "Wellness");
    }
}
