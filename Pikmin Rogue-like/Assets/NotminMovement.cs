using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotminMovement : MonoBehaviour 
{

    private GameObject wayPoint;
    private Vector3 wayPointPos;

    public float lookAtDistance;
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
        float Dist = Vector3.Distance(wayPoint.transform.position, transform.position);
        while (Dist > lookAtDistance)
        {
            wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
            //Here, Notmin follow waypoint.
            transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
        }
    }
}
