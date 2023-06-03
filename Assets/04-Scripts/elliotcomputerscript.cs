using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class elliotcomputerscript : MonoBehaviour
{
    public void OnActivate()
    {
        MainManager.Instance.lelliotActivate();
        SceneManager.LoadScene(sceneName: "elliotsus");
    }
}
