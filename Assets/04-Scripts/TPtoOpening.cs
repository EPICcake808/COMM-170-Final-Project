using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPtoOpening : MonoBehaviour
{
    public void OnActivate()
    {
        SceneManager.LoadScene(sceneName: "Open");
    }
}