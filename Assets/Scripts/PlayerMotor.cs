﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            anim.SetBool("isShooting", true);
        }
        else{
            anim.SetBool("isShooting", false);
        }
	}
}
