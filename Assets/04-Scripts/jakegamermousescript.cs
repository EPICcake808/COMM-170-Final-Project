using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jakegamermousescript : MonoBehaviour
{
    public Player thisPlayer;
    public Transform returnCoord;
    public void OnActivate()
    {
        MainManager.Instance.jakeActivate();
        MainManager.Instance.videoname = "Empty Jake.mp4";
        SceneManager.LoadScene(sceneName: "saunder sniffing");
        thisPlayer.SaveData(returnCoord);
    }
}
