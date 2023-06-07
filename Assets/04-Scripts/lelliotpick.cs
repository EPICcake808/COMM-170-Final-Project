using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lelliotpick : MonoBehaviour
{
    public Rigidbody rb;
    public void OnLelliotPick()
    {
        rb = GetComponent<Rigidbody>();
        if(MainManager.Instance.pickHappened == false)
        {
            Debug.Log("You picked correctly!");
            MainManager.Instance.correctPick = true;
            MainManager.Instance.pickHappened = true;
            walldestroy.Instance.DestroyWall();
            StartCoroutine(Eject(rb));
            changetextcorrect.Instance.StartChangeText();
        }
    }

    IEnumerator Eject(Rigidbody rb)
    {
        yield return new WaitForSeconds(1f);
        rb.velocity = new Vector3(0, 5, -100);
    }
}
