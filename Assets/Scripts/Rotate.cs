using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public Transform target;
    public int speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(target);
        transform.Rotate(Vector3.right * speed * Time.fixedDeltaTime);
    }
}
