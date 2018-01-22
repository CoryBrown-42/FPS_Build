using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

    [SerializeField]
    private float healthVal;

    [SerializeField]
    private float xpVal;

    private float lvlVal;

    [SerializeField]
    private float staminaVal;

    [SerializeField]
    private Text lvlText;
    [SerializeField]
    private Text xpText;


    //UI Sliders represent health
    [SerializeField]
    private Slider healthBar;
    [SerializeField]
    private Slider staminaBar;
    [SerializeField]
    private Slider xpBar;

    [SerializeField]
    private float medkitVal = 20.0f;
    [SerializeField]
    private float bandageVal = 5.0f;

    private float maxHealth = 100.0f;
    private float maxStamina = 100.0f;

    private float maxXP = 100;

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

        lvlVal = 1;
        
	}

    private void FixedUpdate()
    {
        healthBar.value  = healthVal;
        staminaBar.value = staminaVal;
        xpBar.value      = xpVal;
        lvlText.text = "lvl " + lvlVal + "";
        xpText.text = "" + Mathf.Round(xpVal) + " / 100 xp";


        if (xpVal >= 100)
        {
            lvlVal++;
            xpVal = 0;
        }
        

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
        xpVal += 5;

    }

    public void addXP()
    {
        xpVal += 0.3f;
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

