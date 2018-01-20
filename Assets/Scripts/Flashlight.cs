using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {


    Light flashLight;
	// Use this for initialization
	void Start ()
    {
        flashLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashLight.enabled = !flashLight.enabled;
        }
		
	}
}
