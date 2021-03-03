using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyPlanet : MonoBehaviour {

	public bool marsBought;
	public bool earthBought;
	public bool saturnBought;
	public bool neptuneBought;
	public bool jupiterBought;
	public bool mercuryBought;
    public bool venusBought;
    public bool uranusBought;
    public bool moonBought;
    public bool europaBought;
    public bool mimasBought;
    public bool ganymadeBought;
    public GameManager gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void savedData(){
		PlayerPrefs.SetInt("saturnBought", 0);
		PlayerPrefs.SetInt("marsBought", 0);
		PlayerPrefs.SetInt("earthBought", 1);
		PlayerPrefs.SetInt("neptuneBought", 0);
		PlayerPrefs.SetInt("jupiterBought", 0);
		PlayerPrefs.SetInt("mercuryBought", 0);
        PlayerPrefs.SetInt("venusBought", 0);
        PlayerPrefs.SetInt("uranusBought", 0);
        PlayerPrefs.SetInt("moonBought", 0);
        PlayerPrefs.SetInt("europaBought", 0);
        PlayerPrefs.SetInt("mimasBought", 0);
        PlayerPrefs.SetInt("ganymadeBought", 0);
    }

	public void checkIfBuyed(string planet) {
		prefToBool();

		if (planet == "mars"){
			
			gameManager.setPlanet(planet, marsBought);
		}

		if (planet == "earth"){
			
			gameManager.setPlanet(planet, earthBought);
		}

		if (planet == "saturn"){
			
			gameManager.setPlanet(planet, saturnBought);
		}

		if (planet == "neptune"){
			
			gameManager.setPlanet(planet, neptuneBought);	
		}

		if (planet == "jupiter"){
			
			gameManager.setPlanet(planet, jupiterBought);	
		}

		if (planet == "mercury"){
			
			gameManager.setPlanet(planet, mercuryBought);	
		}

        if (planet == "venus")
        {

            gameManager.setPlanet(planet, venusBought);
        }

        if (planet == "uranus")
        {

            gameManager.setPlanet(planet, uranusBought);
        }

        if (planet == "moon")
        {

            gameManager.setPlanet(planet, moonBought);
        }

        if (planet == "europa")
        {

            gameManager.setPlanet(planet, europaBought);
        }

        if (planet == "mimas")
        {

            gameManager.setPlanet(planet, mimasBought);
        }
        if (planet == "ganymade")
        {

            gameManager.setPlanet(planet, ganymadeBought);
        }
    }

	public void prefToBool(){
		int marsBoughtValue = (PlayerPrefs.GetInt("marsBought"));
		if (marsBoughtValue == 0){marsBought = false;}
		else if (marsBoughtValue == 1){marsBought = true;}

		int earthBoughtValue = (PlayerPrefs.GetInt("earthBought"));
		if (earthBoughtValue == 0){earthBought = false;}
		else if (earthBoughtValue == 1){earthBought = true;}

		int saturnBoughtValue = (PlayerPrefs.GetInt("saturnBought"));
		if (saturnBoughtValue == 0){saturnBought = false;}
		else if (saturnBoughtValue == 1){saturnBought = true;}

		int neptuneBoughtValue = (PlayerPrefs.GetInt("neptuneBought"));
		if (neptuneBoughtValue == 0){neptuneBought = false;}
		else if (neptuneBoughtValue == 1){neptuneBought = true;}

		int jupiterBoughtValue = (PlayerPrefs.GetInt("jupiterBought"));
		if (jupiterBoughtValue == 0){jupiterBought = false;}
		else if (jupiterBoughtValue == 1){jupiterBought = true;}

		int mercuryBoughtValue = (PlayerPrefs.GetInt("mercuryBought"));
		if (mercuryBoughtValue == 0){mercuryBought = false;}
		else if (mercuryBoughtValue == 1){mercuryBought = true;}

        int venusBoughtValue = (PlayerPrefs.GetInt("venusBought"));
        if (venusBoughtValue == 0) { venusBought = false; }
        else if (venusBoughtValue == 1) { venusBought = true; }

        int uranusBoughtValue = (PlayerPrefs.GetInt("uranusBought"));
        if (uranusBoughtValue == 0) { uranusBought = false; }
        else if (uranusBoughtValue == 1) { uranusBought = true; }

        int moonBoughtValue = (PlayerPrefs.GetInt("moonBought"));
        if (moonBoughtValue == 0) { moonBought = false; }
        else if (moonBoughtValue == 1) { moonBought = true; }

        int europaBoughtValue = (PlayerPrefs.GetInt("europaBought"));
        if (europaBoughtValue == 0) { europaBought = false; }
        else if (europaBoughtValue == 1) { europaBought = true; }

        int mimasBoughtValue = (PlayerPrefs.GetInt("mimasBought"));
        if (mimasBoughtValue == 0) { mimasBought = false; }
        else if (mimasBoughtValue == 1) { mimasBought = true; }

        int ganymadeBoughtValue = (PlayerPrefs.GetInt("ganymadeBought"));
        if (ganymadeBoughtValue == 0) { ganymadeBought = false; }
        else if (ganymadeBoughtValue == 1) { ganymadeBought = true; }
    }

	public void marsPlanetBought (){
		PlayerPrefs.SetInt("marsBought", 1);
	}

	public void earthPlanetBought (){
		PlayerPrefs.SetInt("earthBought", 1);
	}

	public void saturnPlanetBought (){
		PlayerPrefs.SetInt("saturnBought", 1);
	}

	public void neptunePlanetBought (){
		PlayerPrefs.SetInt("neptuneBought", 1);
	}

	public void jupiterPlanetBought (){
		PlayerPrefs.SetInt("jupiterBought", 1);
	}

	public void mercuryPlanetBought (){
		PlayerPrefs.SetInt("mercuryBought", 1);
	}

    public void venusPlanetBought()
    {
        PlayerPrefs.SetInt("venusBought", 1);
    }

    public void uranusPlanetBought()
    {
        PlayerPrefs.SetInt("uranusBought", 1);
    }

    public void moonPlanetBought()
    {
        PlayerPrefs.SetInt("moonBought", 1);
    }

    public void europaPlanetBought()
    {
        PlayerPrefs.SetInt("europaBought", 1);
    }

    public void mimasPlanetBought()
    {
        PlayerPrefs.SetInt("mimasBought", 1);
    }

    public void ganymadePlanetBought()
    {
        PlayerPrefs.SetInt("ganymadeBought", 1);
    }
}
