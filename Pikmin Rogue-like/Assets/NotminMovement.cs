using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotminMovement : MonoBehaviour 
{

    private GameObject wayPoint;
    private Vector3 wayPointPos;
    
    //Notmin Movement speed.
    public float speed;

	// Use this for initialization
	void Start ()
    {
        //At start, Notmin find the gameobject called wayPoint
        wayPoint = GameObject.Find("wayPoint");
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if (Distance > lookAtDistance)
        {
            wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
            //Here, Notmin follow waypoint.
            transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
        }
    }
}
