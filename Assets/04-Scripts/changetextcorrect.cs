using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changetextcorrect : MonoBehaviour
{
    public static changetextcorrect Instance;

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
        text.text = "You Guessed C";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Co";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Cor";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Corr";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Corre";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Correc";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Correct";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Correctl";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Correctly";
        yield return new WaitForSeconds(0.1f);
        text.text = "You Guessed Correctly!";
    }
}
