using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyShieldColor : MonoBehaviour {

	public bool redBought;
	public bool blueBought;
	public bool greenBought;
	public bool yellowBought;
	public bool purpleBought;
	public bool pinkBought;
    public bool whiteBought;
    public bool orangeBought;
    public bool navyBought;
    public bool brownBought;
    public bool dgreenBought;
    public bool silverBought;
    public GameManager gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void savedData () {
		PlayerPrefs.SetInt("redShieldBought", 0);
		PlayerPrefs.SetInt("blueShieldBought", 1);
		PlayerPrefs.SetInt("greenShieldBought", 0);
		PlayerPrefs.SetInt("yellowShieldBought", 0);
		PlayerPrefs.SetInt("purpleShieldBought", 0);
		PlayerPrefs.SetInt("pinkShieldBought", 0);
        PlayerPrefs.SetInt("whiteShieldBought", 0);
        PlayerPrefs.SetInt("orangeShieldBought", 0);
        PlayerPrefs.SetInt("navyShieldBought", 0);
        PlayerPrefs.SetInt("brownBought", 0);
        PlayerPrefs.SetInt("dgreenBought", 0);
        PlayerPrefs.SetInt("silverBought", 0);
    }

	public void checkIfBuyed(string color) {
		prefToBool();

		if (color == "red"){
			
			gameManager.setShieldColor(color, redBought);
			
		}

		if (color == "blue"){

			gameManager.setShieldColor(color, blueBought);
		}

		if (color == "green"){

			gameManager.setShieldColor(color, greenBought);
		}

		if (color == "yellow"){
			
			gameManager.setShieldColor(color, yellowBought);
		}

		if (color == "purple"){
			
			gameManager.setShieldColor(color, purpleBought);
		}

		if (color == "pink"){
			
			gameManager.setShieldColor(color, pinkBought);
		}

        if (color == "white")
        {

            gameManager.setShieldColor(color, whiteBought);
        }

        if (color == "orange")
        {

            gameManager.setShieldColor(color, orangeBought);
        }

        if (color == "navy")
        {

            gameManager.setShieldColor(color, navyBought);
        }

        if (color == "brown")
        {

            gameManager.setShieldColor(color, brownBought);
        }

        if (color == "dgreen")
        {

            gameManager.setShieldColor(color, dgreenBought);
        }

        if (color == "silver")
        {

            gameManager.setShieldColor(color, silverBought);
        }
    }

	public void prefToBool(){
		int redBoughtValue = (PlayerPrefs.GetInt("redShieldBought"));
		if (redBoughtValue == 0){redBought = false;}
		else if (redBoughtValue == 1){redBought = true;}

		int blueBoughtValue = (PlayerPrefs.GetInt("blueShieldBought"));
		if (blueBoughtValue == 0){blueBought = false;}
		else if (blueBoughtValue == 1){blueBought = true;}

		int greenBoughtValue = (PlayerPrefs.GetInt("greenShieldBought"));
		if (greenBoughtValue == 0){greenBought = false;}
		else if (greenBoughtValue == 1){greenBought = true;}

		int yellowBoughtValue = (PlayerPrefs.GetInt("yellowShieldBought"));
		if (yellowBoughtValue == 0){yellowBought = false;}
		else if (yellowBoughtValue == 1){yellowBought = true;}

		int purpleBoughtValue = (PlayerPrefs.GetInt("purpleShieldBought"));
		if (purpleBoughtValue == 0){purpleBought = false;}
		else if (purpleBoughtValue == 1){purpleBought = true;}

		int pinkBoughtValue = (PlayerPrefs.GetInt("pinkShieldBought"));
		if (pinkBoughtValue == 0){pinkBought = false;}
		else if (pinkBoughtValue == 1){pinkBought = true;}

        int whiteBoughtValue = (PlayerPrefs.GetInt("whiteShieldBought"));
        if (whiteBoughtValue == 0) { whiteBought = false; }
        else if (whiteBoughtValue == 1) { whiteBought = true; }

        int orangeBoughtValue = (PlayerPrefs.GetInt("orangeShieldBought"));
        if (orangeBoughtValue == 0) { orangeBought = false; }
        else if (orangeBoughtValue == 1) { orangeBought = true; }

        int navyBoughtValue = (PlayerPrefs.GetInt("navyShieldBought"));
        if (navyBoughtValue == 0) { navyBought = false; }
        else if (navyBoughtValue == 1) { navyBought = true; }

        int brownBoughtValue = (PlayerPrefs.GetInt("brownShieldBought"));
        if (brownBoughtValue == 0) { brownBought = false; }
        else if (brownBoughtValue == 1) { brownBought = true; }

        int dgreenBoughtValue = (PlayerPrefs.GetInt("dgreenShieldBought"));
        if (dgreenBoughtValue == 0) { dgreenBought = false; }
        else if (dgreenBoughtValue == 1) { dgreenBought = true; }

        int silverBoughtValue = (PlayerPrefs.GetInt("silverShieldBought"));
        if (silverBoughtValue == 0) { silverBought = false; }
        else if (silverBoughtValue == 1) { silverBought = true; }
    }

	public void redColorBought (){
		PlayerPrefs.SetInt("redShieldBought", 1);
	}

	public void blueColorBought (){
		PlayerPrefs.SetInt("blueShieldBought", 1);
	}

	public void greenColorBought (){
		PlayerPrefs.SetInt("greenShieldBought", 1);
	}

	public void yellowColorBought (){
		PlayerPrefs.SetInt("yellowShieldBought", 1);
	}

	public void purpleColorBought (){
		PlayerPrefs.SetInt("purpleShieldBought", 1);
	}

	public void pinkColorBought (){
		PlayerPrefs.SetInt("pinkShieldBought", 1);
	}

    public void whiteColorBought()
    {
        PlayerPrefs.SetInt("whiteShieldBought", 1);
    }

    public void orangeColorBought()
    {
        PlayerPrefs.SetInt("orangeShieldBought", 1);
    }

    public void navyColorBought()
    {
        PlayerPrefs.SetInt("navyShieldBought", 1);
    }

    public void brownColorBought()
    {
        PlayerPrefs.SetInt("brownShieldBought", 1);
    }

    public void dgreenColorBought()
    {
        PlayerPrefs.SetInt("dgreenShieldBought", 1);
    }

    public void silverColorBought()
    {
        PlayerPrefs.SetInt("silverShieldBought", 1);
    }
}
