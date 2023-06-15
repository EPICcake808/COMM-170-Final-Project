using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class elliotcomputerscript : MonoBehaviour
{
    public Player thisPlayer;
    public Transform returnCoord;
    public void OnActivate()
    {
        MainManager.Instance.lelliotActivate();
        MainManager.Instance.videoname = "Empty Elliot.mp4";
        SceneManager.LoadScene(sceneName: "saunder sniffing");
        thisPlayer.SaveData(returnCoord);
    }
}
