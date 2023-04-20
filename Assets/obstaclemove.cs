using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclemove : MonoBehaviour
{
    //array of target waypoints
    public GameObject[] waypoint;
    //calc movement
    private Vector3 Direction;
    public float speed;
    //keep track of target waypoint
    private int i = 0;
    //rigidbody of object
    private Rigidbody rthis;

    //init rigidbody
    void Start(){
        rthis = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        //find direction to target
        Direction = waypoint[i].transform.position - this.transform.position;
        Direction.Normalize();
        //move to target
        this.transform.position = this.transform.position + Direction * Time.deltaTime * speed;
        //increment to next target once reached
        if(Vector3.Distance(this.transform.position, waypoint[i].transform.position) <= 0.2){
            i++;
            if(i >= waypoint.Length){
                i = 0;
            }
        }
    }
    
    
    
}
