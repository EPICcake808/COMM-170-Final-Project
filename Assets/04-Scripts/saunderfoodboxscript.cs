using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saunderfoodboxscript : MonoBehaviour
{
    public void OnActivate()
    {
        MainManager.Instance.videoname = "saunder eating_360.mp4";
        MainManager.Instance.saunderActivate();
        SceneManager.LoadScene(sceneName: "saunder sniffing");
    }
}
