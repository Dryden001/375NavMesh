using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add
using UnityEngine.AI;

public class instnavmesh : MonoBehaviour
{
    //builds navmesh
    public NavMeshSurface surface;
    
    void Start()
    {
        surface.BuildNavMesh();
    }
}
