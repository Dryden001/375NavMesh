using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //required

public class Agent : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    //target
    public GameObject desty;
    //get nav mesh
    private void Awake(){
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        
    }
    //optional move target destination via mouse click
    void Update()
    {
       if(Input.GetMouseButtonDown(0)){
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit)){
                desty.transform.position = hit.point;
            }
        } 
    }

    //set one time to move agent
    public void triggerDes(){
        navMeshAgent.destination = desty.transform.position;
    }
}
