using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPtoWellness : MonoBehaviour
{
    public void OnActivate()
    {
        SceneManager.LoadScene(sceneName: "elliotsus");
    }
}
