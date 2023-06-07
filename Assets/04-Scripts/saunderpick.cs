using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saunderpick : MonoBehaviour
{
    public void OnSaunderPick()
    {
        if(MainManager.Instance.pickHappened == false)
        {
            Debug.Log("You picked wrong!");
            MainManager.Instance.pickHappened = true;
            walldestroy.Instance.DestroyWall();
        }
    }
}
