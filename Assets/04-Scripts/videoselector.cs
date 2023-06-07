using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videoselector : MonoBehaviour
{
    void Awake()
    {
        var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        vp.url = "Assets/07-Videos/" + MainManager.Instance.videoname;
    }
}
