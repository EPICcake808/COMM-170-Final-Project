using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lelliotpick : MonoBehaviour
{
    public void OnPick()
    {
        MainManager.Instance.lelliotpick = true;
        MainManager.Instance.pickHappened = true;
    }
}
