using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotminMovement : MonoBehaviour 
{

    private GameObject wayPoint;
    //private GameObject character;
    private Vector3 wayPointPos;
    private float ProximityOut;
    //Notmin Movement speed.
    public float speed;

	// Use this for initialization
	void Start ()
    {
        //At start, Notmin find the gameobject called wayPoint
        wayPoint = GameObject.Find("wayPoint");
        //character = GameObject.Find("character");
        ProximityOut = 3;
	}

    // Update is called once per frame
    void Update()
    {
        float Dist = Vector3.Distance(wayPoint.transform.position, transform.position);
        if (Dist >= ProximityOut) //|| character.velocity.magnitude > 0)
        {
            wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
            //Here, Notmin follow waypoint.
            transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
        }
    }
}
