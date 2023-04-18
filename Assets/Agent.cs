using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //required

public class Agent : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;

    public GameObject desty;

    private void Awake(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }


    public void triggerDes(){
        navMeshAgent.destination = desty.transform.position;
    }
}
