using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jakegamermousescript : MonoBehaviour
{
    public void OnActivate()
    {
        MainManager.Instance.jakeActivate();
        MainManager.Instance.videoname = "cyle fixing_360.mp4";
        SceneManager.LoadScene(sceneName: "saunder sniffing");
    }

}
