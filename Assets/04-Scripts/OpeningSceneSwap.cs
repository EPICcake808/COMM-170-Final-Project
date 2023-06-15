using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningSceneSwap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "exit_intro")
        {
            SceneManager.LoadScene(sceneName: "imaginarium");
            //SceneManager.LoadScene(sceneName: "Game", LoadSceneMode.Additive);
            Debug.Log("triggered");
        }
    }
    
}
