using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycollider : MonoBehaviour
{
    public static destroycollider Instance;
    public MeshCollider Collider;
    public Rigidbody rb;

    public void DestroyCollider(string name)
    {
        var objects = GameObject.FindGameObjectsWithTag("npc");
        var count = objects.Length;
        var NoDestroy = GameObject.Find(name);
        foreach(var obj in objects)
        {
            if(obj == NoDestroy)
            {
                continue;
            }
            else
            {
                Collider = obj.GetComponent<MeshCollider>();
                rb = obj.GetComponent<Rigidbody>();
                Destroy(Collider);
                Destroy(rb);
            }
        }
    }
}
