using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jakepick : MonoBehaviour
{
    public void OnJakePick()
    {
        if(MainManager.Instance.pickHappened == false)
        {
            Debug.Log("You picked wrong!");
            MainManager.Instance.pickHappened = true;
            walldestroy.Instance.DestroyWall();
        }
    }
}
