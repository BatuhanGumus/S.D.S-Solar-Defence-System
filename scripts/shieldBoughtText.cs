using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shieldBoughtText : MonoBehaviour {

	public buyShieldColor buyShieldColor;
	public Text redBoughtText;
	public Text blueBoughtText;
	public Text greenBoughtText;
	public Text yellowBoughtText;
	public Text purpleBoughtText;
	public Text pinkBoughtText;
    public Text whiteBoughtText;
    public Text orangeBoughtText;
    public Text navyBoughtText;
    public Text brownBoughtText;
    public Text dgreenBoughtText;
    public Text silverBoughtText;

    // Use this for initialization
    void Start () {
		changeText();
	
		
	}
	
	// Update is called once per frame
	void Update () {
		changeText();
		
	}

	public void changeText (){

		buyShieldColor.prefToBool();


		if (buyShieldColor.redBought == true){
			redBoughtText.text = "red";
		}

		if (buyShieldColor.greenBought == true){
			greenBoughtText.text = "green";
		}

		if (buyShieldColor.yellowBought == true){
			yellowBoughtText.text = "yellow";
		}

		if (buyShieldColor.purpleBought == true){
			purpleBoughtText.text = "purple";
		}

		if (buyShieldColor.pinkBought == true){
			pinkBoughtText.text = "pink";
		}

        if (buyShieldColor.whiteBought == true)
        {   
            whiteBoughtText.text = "white";
        }

        if (buyShieldColor.orangeBought == true)
        {
            orangeBoughtText.text = "orange";
        }

        if (buyShieldColor.navyBought == true)
        {
            navyBoughtText.text = "d, blue";
        }

        if (buyShieldColor.brownBought == true)
        {
            brownBoughtText.text = "brown";
        }

        if (buyShieldColor.dgreenBought == true)
        {
            dgreenBoughtText.text = "dgreen";
        }

        if (buyShieldColor.silverBought == true)
        {
            silverBoughtText.text = "silver";
        }
    }

	
}
