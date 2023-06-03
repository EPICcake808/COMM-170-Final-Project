using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerScript : MonoBehaviour
{
    public void OnGrab()
    {
        SceneManager.LoadScene(sceneName: "test");
    }
}
