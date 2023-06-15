using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cylehintscript : MonoBehaviour
{
    public Player thisPlayer;
    public Transform returnCoord;
    public void OnActivate()
    {
        MainManager.Instance.cyleActivate();
        MainManager.Instance.videoname = "cyle fixing_360.mp4";
        SceneManager.LoadScene(sceneName: "saunder sniffing");
        thisPlayer.SaveData(returnCoord);
    }

}