using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saundersummonscript : MonoBehaviour
{
    public Player thisPlayer;
    public Transform returnCoord;
    public void OnActivate()
    {
        MainManager.Instance.saunderSummon();
        MainManager.Instance.videoname = "saunder summons elliot_360.mp4";
        SceneManager.LoadScene(sceneName: "saunder sniffing");
        thisPlayer.SaveData(returnCoord);
    }

}