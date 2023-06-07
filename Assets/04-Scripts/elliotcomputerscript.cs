using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class elliotcomputerscript : MonoBehaviour
{
    public void OnActivate()
    {
        MainManager.Instance.lelliotActivate();
        MainManager.Instance.videoname = "saunder summons elliot_360.mp4";
        SceneManager.LoadScene(sceneName: "saunder sniffing");
    }
}
