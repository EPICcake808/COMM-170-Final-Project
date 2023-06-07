using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jakepick : MonoBehaviour
{
    public Rigidbody rb;
    public void OnJakePick()
    {
        rb = GetComponent<Rigidbody>();
        if(MainManager.Instance.pickHappened == false)
        {
            Debug.Log("You picked wrong!");
            MainManager.Instance.pickHappened = true;
            walldestroy.Instance.DestroyWall();
            StartCoroutine(Eject(rb));
            changetextwrong.Instance.StartChangeText();
        }
    }

    IEnumerator Eject(Rigidbody rb)
    {
        yield return new WaitForSeconds(1f);
        rb.velocity = new Vector3(0, 5, -100);
    }
}
