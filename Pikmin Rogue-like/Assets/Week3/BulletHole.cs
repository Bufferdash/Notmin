using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHole : MonoBehaviour {

    Camera cam;
    public float range;
    public GameObject Bullethole;

	// Use this for initialization
	void Start () 
    {
        cam = GetComponentInParent<Camera>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetMouseButtonDown(0))
        {
            RayShoot();
        }
	}

    void RayShoot()
    {
        Vector3 rayOrigin = cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 1.5f)); //Makes a space in the world
        RaycastHit hit; //holds info if hit
        if(Physics.Raycast(rayOrigin, cam.transform.forward, out hit, range))
        {
            if(hit.transform.gameObject.GetComponent<Shootable>())
            {
                Instantiate(Bullethole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
            }
        }
    }
}