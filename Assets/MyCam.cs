using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCam : MonoBehaviour {

    public float cameraSpeed = 0.1F;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 v = transform.position;
            v.x = v.x + cameraSpeed;
            transform.position = v;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 v = transform.position;
            v.x = v.x - cameraSpeed;
            transform.position = v;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 v = transform.position;
            v.z = v.z + cameraSpeed;
            transform.position = v;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 v = transform.position;
            v.z = v.z - cameraSpeed;
            transform.position = v;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Vector3 v = transform.position;
            v.y = v.y + cameraSpeed;
            transform.position = v;
        }
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            Vector3 v = transform.position;
            v.y = v.y - cameraSpeed;
            transform.position = v;
        }
    }
}
