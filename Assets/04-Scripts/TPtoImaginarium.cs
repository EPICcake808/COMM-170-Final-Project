using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TPtoImaginarium : MonoBehaviour
{
    public void OnActivate()
    {
        SceneManager.LoadScene(sceneName: "Imaginarium");
    }
}
