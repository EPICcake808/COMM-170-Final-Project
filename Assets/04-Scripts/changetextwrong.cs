using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class changetextwrong : MonoBehaviour
{
    public static changetextwrong Instance;

    [SerializeField] TMP_Text text;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartChangeText()
    {
        StartCoroutine(ChangeText());
    }

    IEnumerator ChangeText() 
    {
        text.text = "";
        yield return new WaitForSeconds(5f);
        text.text = "Y";
        yield return new WaitForSeconds(0.1f);
        text.text = "Yo";
        yield return new WaitForSeconds(0.1f);
        text.text = "You";
        yield return new WaitForSeconds(0.3f);
        text.text = "You ";
        yield return new WaitForSeconds(0.1f);
        text.text = "You G";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Gu";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Gue";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Gues";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guess";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guesse";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed";
        yield return new WaitForSeconds(0.3f);
        text.text = "You Guessed ";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed W";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Wr";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Wro";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Wron";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Wrong";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Wrong!";
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(sceneName: "End");
    }
}
