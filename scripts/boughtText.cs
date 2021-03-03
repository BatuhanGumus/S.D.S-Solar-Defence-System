using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boughtText : MonoBehaviour {
	public buyDefenceColor buyDefenceColor;
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

		buyDefenceColor.prefToBool();


		if (buyDefenceColor.redBought == true){
			redBoughtText.text = "red";
		}

		if (buyDefenceColor.greenBought == true){
			greenBoughtText.text = "green";
		}

		if (buyDefenceColor.yellowBought == true){
			yellowBoughtText.text = "yellow";
		}

		if (buyDefenceColor.purpleBought == true){
			purpleBoughtText.text = "purple";
		}

		if (buyDefenceColor.pinkBought == true){
			pinkBoughtText.text = "pink";
		}

        if (buyDefenceColor.whiteBought == true)
        {
            whiteBoughtText.text = "white";
        }

        if (buyDefenceColor.orangeBought == true)
        {
            orangeBoughtText.text = "orange";
        }

        if (buyDefenceColor.navyBought == true)
        {
            navyBoughtText.text = "d, blue";
        }

        if (buyDefenceColor.brownBought == true)
        {
            brownBoughtText.text = "brown";
        }

        if (buyDefenceColor.dgreenBought == true)
        {
            dgreenBoughtText.text = "d, green";
        }

        if (buyDefenceColor.silverBought == true)
        {
            silverBoughtText.text = "silver";
        }
    }

	
}
