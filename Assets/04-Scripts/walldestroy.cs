using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walldestroy : MonoBehaviour
{
    public static walldestroy Instance;
    
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


    public void DestroyWall() 
    {
        Destroy(gameObject);
    }
}
