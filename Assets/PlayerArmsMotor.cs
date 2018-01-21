using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmsMotor : MonoBehaviour {


    public Animator anim;

    public GameObject sword;

    bool Activate;

	// Use this for initialization
	void Start ()
    {
        anim.SetBool("isIdleUnarmed", true);
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(sword.activeSelf == true)
        {
            anim.SetBool("isIdleUnarmed", false);
        }

        if(sword.activeSelf == false)
        {
            anim.SetBool("isIdleUnarmed", true);
        }

        if (sword.activeSelf == true && Input.GetMouseButtonDown(0))
        {
            anim.SetBool("isStabbingSword", true);
        }
        else
        {
            anim.SetBool("isStabbingSword", false);
        }
    }
}
