using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;
using Unity.VisualScripting;

public class SliceObject : MonoBehaviour
{
    public Material materialSliceSide;
    public float explosionForce;
    public float explosionRadius;
    public bool gravity, kinematic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CanSlice"))
        {
            SlicedHull sliceobj = Slice(other.gameObject,materialSliceSide);
            GameObject SliceObjTop = sliceobj.CreateUpperHull(other.gameObject, materialSliceSide);
            GameObject SliceObjDown = sliceobj.CreateUpperHull(other.gameObject, materialSliceSide);
            Destroy(other.gameObject);
            //AddComponent(SliceObjTop);
            //AddComponent(SliceObjDown);
        }

    }
    private SlicedHull Slice(GameObject obj, Material mat)
    {
        return obj.Slice(transform.position, transform.up, mat);
    }
    /*
    void AddComponent(GameObject obj)
    {
        obj.AddComponent<BoxCollider>();
        var rigidbody = obj.AddComponent<Rigidbody>();
        rigidbody.useGravity = gravity;
        rigidbody.isKinematic = kinematic;
        rigidbody.AddExplosionForce(explosionForce,obj.transform.position, explosionRadius);
        obj.tag = "CanSlice";
        Destroy(obj, 5f);
    }
    */
}
