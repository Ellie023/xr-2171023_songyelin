using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class D04_Sriipting : MonoBehaviour
{
    MeshFilter ThisMeshFilter;
    public GameObject Sphere, Capsule;
    void Start()
    {
        ThisMeshFilter = GetComponent<MeshFilter>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ThisMeshFilter.mesh = Sphere.GetComponent<MeshFilter>().mesh;
        }
        if (Input.GetMouseButtonDown(1))
        {
            ThisMeshFilter.mesh = Capsule.GetComponent<MeshFilter>().mesh;
        }
    }
}