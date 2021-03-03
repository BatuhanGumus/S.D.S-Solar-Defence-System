using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyDefenceColor : MonoBehaviour {

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
		PlayerPrefs.SetInt("redBought", 0);
		PlayerPrefs.SetInt("blueBought", 1);
		PlayerPrefs.SetInt("greenBought", 0);
		PlayerPrefs.SetInt("yellowBought", 0);
		PlayerPrefs.SetInt("purpleBought", 0);
		PlayerPrefs.SetInt("pinkBought", 0);
        PlayerPrefs.SetInt("whiteBought", 0);
        PlayerPrefs.SetInt("orangeBought", 0);
        PlayerPrefs.SetInt("navyBought", 0);
        PlayerPrefs.SetInt("brownBought", 0);
        PlayerPrefs.SetInt("dgreenBought", 0);
        PlayerPrefs.SetInt("silverBought", 0);
    }

	public void checkIfBuyed(string color) {
		prefToBool();

		if (color == "red"){
			
			gameManager.setDefenceColor(color, redBought);
		}

		if (color == "blue"){

			gameManager.setDefenceColor(color, blueBought);
		}

		if (color == "green"){

			gameManager.setDefenceColor(color, greenBought);
		}

		if (color == "yellow"){
			
			gameManager.setDefenceColor(color, yellowBought);
		}

		if (color == "purple"){
			
			gameManager.setDefenceColor(color, purpleBought);
		}

		if (color == "pink"){
			
			gameManager.setDefenceColor(color, pinkBought);
		}

        if (color == "white")
        {

            gameManager.setDefenceColor(color, whiteBought);
        }

        if (color == "orange")
        {

            gameManager.setDefenceColor(color, orangeBought);
        }

        if (color == "navy")
        {

            gameManager.setDefenceColor(color, navyBought);
        }

        if (color == "brown")
        {

            gameManager.setDefenceColor(color, brownBought);
        }

        if (color == "dgreen")
        {

            gameManager.setDefenceColor(color, dgreenBought);
        }

        if (color == "silver")
        {

            gameManager.setDefenceColor(color, silverBought);
        }
    }

	public void prefToBool(){
		int redBoughtValue = (PlayerPrefs.GetInt("redBought"));
		if (redBoughtValue == 0){redBought = false;}
		else if (redBoughtValue == 1){redBought = true;}

		int blueBoughtValue = (PlayerPrefs.GetInt("blueBought"));
		if (blueBoughtValue == 0){blueBought = false;}
		else if (blueBoughtValue == 1){blueBought = true;}

		int greenBoughtValue = (PlayerPrefs.GetInt("greenBought"));
		if (greenBoughtValue == 0){greenBought = false;}
		else if (greenBoughtValue == 1){greenBought = true;}

		int yellowBoughtValue = (PlayerPrefs.GetInt("yellowBought"));
		if (yellowBoughtValue == 0){yellowBought = false;}
		else if (yellowBoughtValue == 1){yellowBought = true;}

		int purpleBoughtValue = (PlayerPrefs.GetInt("purpleBought"));
		if (purpleBoughtValue == 0){purpleBought = false;}
		else if (purpleBoughtValue == 1){purpleBought = true;}

		int pinkBoughtValue = (PlayerPrefs.GetInt("pinkBought"));
		if (pinkBoughtValue == 0){pinkBought = false;}
		else if (pinkBoughtValue == 1){pinkBought = true;}

        int whiteBoughtValue = (PlayerPrefs.GetInt("whiteBought"));
        if (whiteBoughtValue == 0) { whiteBought = false; }
        else if (whiteBoughtValue == 1) { whiteBought = true; }

        int orangeBoughtValue = (PlayerPrefs.GetInt("orangeBought"));
        if (orangeBoughtValue == 0) { orangeBought = false; }
        else if (orangeBoughtValue == 1) { orangeBought = true; }

        int navyBoughtValue = (PlayerPrefs.GetInt("navyBought"));
        if (navyBoughtValue == 0) { navyBought = false; }
        else if (navyBoughtValue == 1) { navyBought = true; }

        int brownBoughtValue = (PlayerPrefs.GetInt("brownBought"));
        if (brownBoughtValue == 0) { brownBought = false; }
        else if (brownBoughtValue == 1) { brownBought = true; }

        int dgreenBoughtValue = (PlayerPrefs.GetInt("dgreenBought"));
        if (dgreenBoughtValue == 0) { dgreenBought = false; }
        else if (dgreenBoughtValue == 1) { dgreenBought = true; }

        int silverBoughtValue = (PlayerPrefs.GetInt("silverBought"));
        if (silverBoughtValue == 0) { silverBought = false; }
        else if (silverBoughtValue == 1) { silverBought = true; }
    }

	public void redColorBought (){
		PlayerPrefs.SetInt("redBought", 1);
	}

	public void blueColorBought (){
		PlayerPrefs.SetInt("blueBought", 1);
	}

	public void greenColorBought (){
		PlayerPrefs.SetInt("greenBought", 1);
	}

	public void yellowColorBought (){
		PlayerPrefs.SetInt("yellowBought", 1);
	}

	public void purpleColorBought (){
		PlayerPrefs.SetInt("purpleBought", 1);
	}

	public void pinkColorBought (){
		PlayerPrefs.SetInt("pinkBought", 1);
	}

    public void whiteColorBought()
    {
        PlayerPrefs.SetInt("whiteBought", 1);
    }

    public void orangeColorBought()
    {
        PlayerPrefs.SetInt("orangeBought", 1);
    }

    public void navyColorBought()
    {
        PlayerPrefs.SetInt("navyBought", 1);
    }

    public void brownColorBought()
    {
        PlayerPrefs.SetInt("brownBought", 1);
    }

    public void dgreenColorBought()
    {
        PlayerPrefs.SetInt("dgreenBought", 1);
    }

    public void silverColorBought()
    {
        PlayerPrefs.SetInt("silverBought", 1);
    }
}
