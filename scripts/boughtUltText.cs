using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boughtUltText : MonoBehaviour {
    public upgradeAbility upgradeAbility;
    public Text shieldultBoughtText;
    public Text defenceultBoughtText;
    public Text timeultBoughtText;
    public RawImage shieldimage;
    public RawImage stickimage;
    public RawImage timeimage;

    // Use this for initialization
    void Start () {
        changeText();

    }
	
	// Update is called once per frame
	void Update () {
        changeText();

    }

    public void changeText()
    {

        upgradeAbility.prefToBool();


        if (upgradeAbility.shieldUltBought == true)
        { 
            shieldultBoughtText.text = "Fix Shield";
            shieldimage.color = new Color(0f, 1f, 1f);
        }

        if (upgradeAbility.defenceUltBought == true)
        {
            defenceultBoughtText.text = "Power Defence";
            stickimage.color = new Color(0f, 1f, 1f);
        }

        if (upgradeAbility.timeUltBought == true)
        {
            timeultBoughtText.text = "Concentrate";
            timeimage.color = new Color(0f, 1f, 1f);
        }
    }
    }
