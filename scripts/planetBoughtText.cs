using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planetBoughtText : MonoBehaviour {

	public buyPlanet buyPlanet;
	public Text marsBoughtText;
	public Text saturnBoughtText;
	public Text neptuneBoughtText;
	public Text jupiterBoughtText;
	public Text mercuryBoughtText;
    public Text venusBoughtText;
    public Text uranusBoughtText;
    public Text moonBoughtText;
    public Text europaBoughtText;
    public Text mimasBoughtText;
    public Text ganymadeBoughtText;

    // Use this for initialization
    void Start () {
		changePlanetBoughtText();

    }
	
	// Update is called once per frame
	void Update () {
		changePlanetBoughtText();

    }

	public void changePlanetBoughtText(){
		buyPlanet.prefToBool();
       

        if (buyPlanet.marsBought == true){
			marsBoughtText.text = "Mars";
		}

		if (buyPlanet.saturnBought == true){
			saturnBoughtText.text = "Saturn";
		}

		if (buyPlanet.neptuneBought == true){
			neptuneBoughtText.text = "Neptune";
		}

		if (buyPlanet.jupiterBought == true){
			jupiterBoughtText.text = "Jupiter";
		}

		if (buyPlanet.mercuryBought == true){
			mercuryBoughtText.text = "Mercury";
		}

        if (buyPlanet.venusBought == true)
        {
            venusBoughtText.text = "Venus";
        }

        if (buyPlanet.uranusBought == true)
        {
            uranusBoughtText.text = "Uranus";
        }

    }

    public void changeMoonBoughtText()
    {
        buyPlanet.prefToBool();
        if (buyPlanet.moonBought == true)
        {
            moonBoughtText.text = "Moon";
        }
        if (buyPlanet.europaBought == true)
        {
            europaBoughtText.text = "Europa";
        }
        if (buyPlanet.mimasBought == true)
        {
            mimasBoughtText.text = "Mimas";
        }
        if (buyPlanet.ganymadeBought == true)
        {
            ganymadeBoughtText.text = "Ganymade";
        }
    }
}
