using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jakegamermousescript : MonoBehaviour
{
    public void OnActivate()
    {
        MainManager.Instance.jakeActivate();
        SceneManager.LoadScene(sceneName: "elliotsus");
    }

}
