using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycollider : MonoBehaviour
{
    public static destroycollider Instance;
    public MeshCollider Collider;
    public Rigidbody rb;
    
    private void Awake()
    {
        Instance = this;
    }

/*  I realize I could have done this the by adding colliders and rigidbodies instead, and that would have been so much easier and more efficient.
 *  But I've already put the colliders and rigidbodies on the models so screw it, we're doing it backwards.
*/

    public void DestroyCollider(string name)
    {
        var objects = GameObject.FindGameObjectsWithTag("npc");
        var count = objects.Length;
/*        Debug.Log("GameObjects found:");
        foreach (var o in objects)
        {
            Debug.Log(o.name);
        }
*/
        var NoDestroy = GameObject.Find(name);
        foreach(var obj in objects)
        {
            if(obj != NoDestroy)
            {
                Collider = obj.GetComponent<MeshCollider>();
                rb = obj.GetComponent<Rigidbody>();
                Destroy(Collider);
                Destroy(rb);
            }
        }
    }
}
