using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lelliotpick : MonoBehaviour
{
    public void OnLelliotPick()
    {
        if(MainManager.Instance.pickHappened == false)
        {
            Debug.Log("You picked correctly!");
            MainManager.Instance.pickHappened = true;
            walldestroy.Instance.DestroyWall();
        }
    }
}