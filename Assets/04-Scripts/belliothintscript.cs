using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class belliothintscript : MonoBehaviour
{
    public void OnActivate()
    {
        MainManager.Instance.belliotActivate();
        MainManager.Instance.videoname = "saunder sniffing_360.mp4";
        SceneManager.LoadScene(sceneName: "saunder sniffing");
    }

}
