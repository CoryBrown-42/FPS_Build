using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    [SerializeField]
    public float healthVal;
    [SerializeField]
    private float staminaVal;
    //UI Sliders represent health
    [SerializeField]
    private Slider healthBar;
    [SerializeField]
    private Slider staminaBar;
    [SerializeField]
    private float medkitVal = 20.0f;
    [SerializeField]
    private float bandageVal = 5.0f;

    private float maxHealth = 100.0f;
    private float maxStamina = 100.0f;

    private float minHealth = 0f;
    private float minStamina = 0f;

    public float damage = 10.0f;
    [SerializeField]
    private float fatigue = 0.05f;
    [SerializeField]
    private float stamRegen = 0.05f;

    void Start ()
    {
        healthVal = 100;
        staminaVal = 100;
        maxHealth = 100;
        maxStamina = 100;
	}

    private void FixedUpdate()
    {
        healthBar.value = healthVal;
        staminaBar.value = staminaVal;


        if(healthVal >= maxHealth)
        {
            healthVal = 100;
        }
        if(staminaVal >= maxStamina)
        {
            staminaVal = 100;
        }

        if (healthVal <= minHealth)
        {
            healthVal = 0;
        }
        if (staminaVal <= minStamina)
        {
            staminaVal = 0;
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            staminaVal -= fatigue;
        }
        else
        {
            staminaVal += stamRegen;
        }
    }


    public void addHealthMedkit()
    {
        healthVal += medkitVal;
    }


    public void addHealthBandage()
    { 
        healthVal += bandageVal;
    }


    public void minusHealth()
    {
        healthVal -= damage;
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {

            minusHealth();
        }
    }
        private void OnTriggerExit(Collider col)
        {
            pickup DangerPrompt = FindObjectOfType<pickup>();
            DangerPrompt.pickUp_text.color = Color.black;
            DangerPrompt.pickupPrompt.SetActive(false);

        }
        


    }

