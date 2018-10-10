using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWaypoint : MonoBehaviour 
{

    //In editor, add your wayPoint gameobject to the script
    public GameObject wayPoint;
    //How often your waypoint's position will update to the player's position
    private float timer = .5f;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		if(timer>0)
        {
            timer -= Time.deltaTime;
        }
        if(timer <= 0)
        {
            //Position update
            UpdatePosition();
            timer = .5f;
        }
	}

    void UpdatePosition()
    {
        //the wayPoint's position will now be the player's current position.
        wayPoint.transform.position = transform.position;
    }
}
