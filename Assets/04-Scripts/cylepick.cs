using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylepick : MonoBehaviour
{
    public Rigidbody rb;
    public void OnCylePick()
    {
        rb = GetComponent<Rigidbody>();
        if(MainManager.Instance.pickHappened == false)
        {
            Debug.Log("You picked wrong!");
            MainManager.Instance.pickHappened = true;
            walldestroy.Instance.DestroyWall();
            destroycollider.Instance.DestroyCollider(gameObject.name);
            StartCoroutine(Eject(rb));
            changetextwrong.Instance.StartChangeText();
            MainManager.Instance.cylePick = true;
        }
    }

    IEnumerator Eject(Rigidbody rb)
    {
        yield return new WaitForSeconds(1f);
        rb.velocity = new Vector3(0, 5, -100);
    }
}
