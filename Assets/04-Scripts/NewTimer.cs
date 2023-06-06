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
    void Start()
    {
        timeLeft = PlayerPrefs.GetFloat("timerCount");
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft <= 0)
        {
            SceneManager.LoadScene(sceneName: "elliotsus");
        }
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
    }
}
